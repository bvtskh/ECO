using ADGV;
using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.DATA.Entities.PI_BASE;
using ECO_DX_For_PUR.Utils;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormWOPlan : Form
    {
        IWO _woHelper = new WOHelper();
        DataTable dataTable;
        USAPService.USAPWebServiceSoapClient _usap = new USAPService.USAPWebServiceSoapClient();
        List<KeyValuePair<string, string>> customerInfo;
        public FormWOPlan()
        {
            //var fileName = _usap.GetFullPathDocument("dasdasjd");
            InitializeComponent();
            rdoPending.Checked = true;
            cbCustomer.Font = new Font("Tahoma", 11F, FontStyle.Regular);
            Common.SetHeaderColor(dgvPlan);
            InitTagTextbox();
        }



        private void FormWOPlan_Load(object sender, EventArgs e)
        {
            try
            {
                FitColumns(dgvPlan);
                // cbCustomer.Items.AddRange(customerInfo.Select(w => w.Value).Distinct().ToArray());
                List<Area> areaList = _woHelper.GetAreaList();
                cbCustomer.Items.AddRange(areaList.Select(s=>s.AREA1).Distinct().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ResetFilter();
                Common.StartFormLoading();
                //customerInfo = Common.CreateCustomer();
                List<WoChanging> dataPlaning = new List<WoChanging>();

                if (rdoAll.Checked)
                {
                    dataPlaning = _woHelper.GetWOPlaning(0);
                }
                if (rdoPending.Checked)
                {
                    UpdateWochanging(_woHelper.GetWOPlaning(1));
                    dataPlaning = _woHelper.GetWOPlaning(1).OrderBy(o => o.DEPT_ORD).ThenBy(t => t.TYPE_ID).ThenBy(t1 => t1.ORDER_NO).ToList();

                }
                lblStatus.Text = $"{dataPlaning.Count()} Rows";
                dataTable = ToDataTableWOPlan(dataPlaning);
                Common.CloseFormLoading();
                this.bindingSource1.DataSource = dataTable;
                dgvPlan.DataSource = this.bindingSource1.DataSource;
                FitColumns(dgvPlan);
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ResetFilter()
        {
            this.bindingSource1.Sort = null;
            this.bindingSource1.Filter = null;
        }

        private DataTable ToDataTableWOPlan(List<WoChanging> dataPlaning)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Customer");
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("WO");
                dataTable.Columns.Add("ECO_No");
                dataTable.Columns.Add("Type");
                dataTable.Columns.Add("Kitting Date");
                dataTable.Columns.Add("SMT Status");
                dataTable.Columns.Add("FAT Status");
                foreach (var item in dataPlaning)
                {
                    var dataUsap = _usap.GetECO(item.ECO_NO);
                    DataRow row = dataTable.NewRow();
                    row["Customer"] = dataUsap == null ? "" : dataUsap.CUS_CODE.ToString();//ConvertShortCustomerName(dataUsap.CUS_CODE);
                    row["Model"] = dataUsap == null ? "" : dataUsap.PART_NO;
                    row["WO"] = item.ORDER_NO;
                    row["ECO_No"] = item.ECO_NO;
                    row["Type"] = Common.GetType(item.TYPE_ID);
                    row["Kitting Date"] = item.DUE_DATE.ToString("MM/dd/yyyy");
                    row["SMT Status"] = GetStatusWO(item.DEPT_ORD, 0); // 14 => ok
                    row["FAT Status"] = GetStatusWO(item.DEPT_ORD, 1); //15 => ok
                    dataTable.Rows.Add(row);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// id =0 =>SMT, id=1 => FAT;
        /// </summary>
        /// <param name="dept_order"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private string GetStatusWO(int? dept_order, int id)
        {
            if (id == 0) //SMT
            {
                if (dept_order >= 14)
                {
                    return "OK";
                }
                else if (dept_order < 14)
                {
                    return "Pending";
                }
                else return "";
            }
            if (id == 1) //FAT
            {
                if (dept_order >= 15)
                {
                    return "OK";
                }
                else if (dept_order < 15)
                {
                    return "Pending";
                }
                else return "";
            }
            return "";
        }

        private string ConvertShortCustomerName(string cUS_CODE)
        {
            if (customerInfo != null)
            {
                var a = customerInfo.Where(w => cUS_CODE.StartsWith(w.Key)).Select(s => s.Value).FirstOrDefault();
                return a;
            }
            return null;
        }

        private void UpdateWochanging(List<WoChanging> dataWoChanging)
        {
            try
            {
                using (var _context = new DBContext())
                {
                    foreach (var item in dataWoChanging)
                    {
                        var dataUsap = _usap.GetECO(item.ECO_NO);
                        SqlParameter[] pr = new SqlParameter[3]
                        {
                        new SqlParameter("@ECO_no", item.ECO_NO),
                        new SqlParameter("@Dept_order", dataUsap.ORD_NO),
                        new SqlParameter("@Dept_name", dataUsap.DEPT_CODE)
                        };

                        _context.Database.ExecuteSqlCommand("exec UpdateWOChanging @ECO_no, @Dept_order, @Dept_name", pr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
      

        private void FitColumns(AdvancedDataGridView dgv)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    var rowList = dgv.Rows.Cast<DataGridViewRow>().ToList();
                    foreach (DataGridViewRow row in rowList)
                    {
                        string SMTstatus = row.Cells["SMT Status"].Value == null ? "" : row.Cells["SMT Status"].Value.ToString();
                        string FATstatus = row.Cells["FAT Status"].Value == null ? "" : row.Cells["FAT Status"].Value.ToString();

                        if (SMTstatus == "OK" && FATstatus == "OK")
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (SMTstatus == "OK" && FATstatus == "Pending")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private DataTable FilterData(DataTable dataTable, string columnName, List<string> searchStringList)
        {
            try
            {
                DataTable dataResult = dataTable.Clone();
                foreach (DataRow row in dataTable.Rows)
                {
                    var valueRow = row.Field<object>(columnName);
                    foreach (var item in searchStringList)
                    {
                        if (valueRow != null && valueRow.ToString().ToLower().Contains(item.ToLower()))
                        {
                            dataResult.Rows.Add(row.ItemArray);
                        }
                    }

                }
                return dataResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void ButonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ResetFilter();
                var objSender = (UIButton)sender;
                string columnName = GetColumnsName(objSender);
                List<string> searchString = new List<string>();
                searchString.Add(GetSearchString(objSender));
                //var codeCustomer = customerInfo.Where(w => w.Value == searchString[0]).Select(s => s.Key).ToList();
               
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString[0]))
                {
                    DataTable data;
                    if ((int)objSender.GetTag(1) == 0) // nếu tìm theo customer
                    {
                        if(cbCustomer.SelectedIndex != -1 && cbCustomer.SelectedIndex != 0)
                        {
                            List<string> customerCode = _woHelper.GetAreaList().Where(w => w.AREA1.Contains(cbCustomer.Text)).Select(s => s.CUSTOMER).ToList();
                            data = FilterData(dataTable, columnName, customerCode);
                        }
                        else
                        {
                            CheckBox_CheckedChanged(null, null);
                            return;
                        }
                    }
                    else
                    {
                        data = FilterData(dataTable, columnName, searchString);
                    }

                    this.bindingSource1.DataSource = data;
                    dgvPlan.DataSource = this.bindingSource1.DataSource;
                    lblStatus.Text = $"{dgvPlan.RowCount} Rows";
                    FitColumns(dgvPlan);
                }
                else
                {
                    CheckBox_CheckedChanged(null, null);
                }
            }        
             catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string GetSearchString(UIButton objSender)
        {
            if (GetObject(objSender.GetTag(0)) is UITextBox)
            {
                UITextBox uITextBox = (UITextBox)objSender.GetTag(0);
                return uITextBox.Text;
            }
            else if (GetObject(objSender.GetTag(0)) is UIComboBox)
            {
                UIComboBox uIComboBox = (UIComboBox)objSender.GetTag(0);
                return uIComboBox.Text;
            }
            return null;
        }

        private string GetColumnsName(UIButton objSender)
        {
            if (GetObject(objSender.GetTag(0)) is UITextBox)
            {
                UITextBox uITextBox = (UITextBox)objSender.GetTag(0);
                return uITextBox.GetTag(0).ToString();
            }
            else if (GetObject(objSender.GetTag(0)) is UIComboBox)
            {
                UIComboBox uITextBox = (UIComboBox)objSender.GetTag(0);
                return uITextBox.GetTag(0).ToString();
            }
            return null;
        }

        private object GetObject(object tag)
        {
            if (tag is UITextBox)
            {
                return (UITextBox)tag;
            }
            if (tag is UIComboBox)
            {
                return (UIComboBox)tag;
            }
            return null;
        }

        private void InitTagTextbox()
        {
            btnCustomer.InitTag(cbCustomer, 0);
            btnModel.InitTag(txtModel, 1);
            btnECO.InitTag(txtECO, 2);
            txtModel.InitTag("Model");
            txtECO.InitTag("ECO_No");
            cbCustomer.InitTag("Customer");
        }

        private void pDFDetailECOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null || selectedRow.Index == -1)
                {
                    if (dgvPlan.RowCount > 0) selectedRow = dgvPlan.Rows[0];
                }
                // Get the content of the "Id" column for the selected row
                if (selectedRow != null && selectedRow.Index != -1)
                {
                    object eco = selectedRow.Cells["ECO_No"].Value;

                    if (eco != null)
                    {
                        string pdfLink = _usap.GetFullPathDocument(eco.ToString());
                        if (!string.IsNullOrEmpty(pdfLink))
                        {
                            FormViewPDF f = new FormViewPDF(pdfLink, eco.ToString());
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show($"PDF not found for USR: {eco.ToString()}");
                        }
                    }
                }
                else
                {
                    FormViewPDF f = new FormViewPDF("", "");
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        DataGridViewRow selectedRow;
        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvPlan.Rows[e.RowIndex];
            }
        }

        private void dgvPlan_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Sort = dgvPlan.SortString;
        }

        private void dgvPlan_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = dgvPlan.FilterString;
        }
    }
}
