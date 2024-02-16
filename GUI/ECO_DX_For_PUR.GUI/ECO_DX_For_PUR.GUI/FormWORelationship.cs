using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.Utils;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormWORelationship : Form
    {
        IWO _woHelper = new WOHelper();
        USAPService.USAPWebServiceSoapClient _usap = new USAPService.USAPWebServiceSoapClient();
        DataTable dataWO;

        public FormWORelationship()
        {
            InitializeComponent();
            customFont();
        }

        private void customFont()
        {
            
            dgvWO.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgvWO.DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Regular);
        }             

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchStr = cbCustomer.SelectedItem as string;
                string columnName = "Customer";
                var codeCustomer = Common.CreateCustomer().Where(w => w.Value == searchStr).Select(s => s.Key).ToList();

                if (!string.IsNullOrEmpty(searchStr))
                {
                    DataTable data;
                    data = FilterData(dataWO, columnName, codeCustomer);
                    dgvWO.DataSource = data;
                }
                else
                {
                    checkBoxPending_ValueChanged(null, false);
                }
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Common.CloseFormLoading();
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

        private DataTable ToDataWORelationship(List<WO_Relationship> dataList)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Customer");
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("AI WO");
                dataTable.Columns.Add("SMTA WO");
                dataTable.Columns.Add("SMTB WO");
                dataTable.Columns.Add("SMT WO");
                dataTable.Columns.Add("FAT WO (1)");
                dataTable.Columns.Add("FAT QTY (1)");
                dataTable.Columns.Add("FAT WO (2)");
                dataTable.Columns.Add("FAT QTY (2)");
                dataTable.Columns.Add("FAT WO (3)");
                dataTable.Columns.Add("FAT QTY (3)");
                var groupData = dataList.GroupBy(g => g.ORDER_BASE);
                foreach (var group in groupData) // tách thành group theo key.
                {
                    var dataUsap = _usap.GetECO(_woHelper.GetECONoByOrderNo(group));
                    var row = dataTable.NewRow();
                    row["Customer"] = dataUsap.CUS_CODE;
                    row["Model"] = dataUsap.PART_NO;
                    row["AI WO"] = GetWO(group, 0);
                    row["SMTA WO"] = GetWO(group, 1);
                    row["SMTB WO"] = GetWO(group, 2);
                    row["SMT WO"] = GetWO(group, 3);
                    List<WO_Relationship> woFAT = GetWOFAT(group, 4);
                    int index = 6;
                    foreach (var item in woFAT)
                    {
                        row[index] = item.ORDER_NO;
                        row[index + 1] = item.QTY;
                        index += 2;
                    }
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

        private string GetWO(IGrouping<Guid?, WO_Relationship> group, int type_ID)
        {
            return group.Where(w => w.TYPE_ID == type_ID).Select(s => s.ORDER_NO).FirstOrDefault();
        }

        private static List<WO_Relationship> GetWOFAT(IGrouping<Guid?, WO_Relationship> group, int type_ID)
        {
            return group.Where(w => w.TYPE_ID == type_ID).ToList();
        }
        private void txtInputINT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvWO.RowCount > 0)
                {
                    var data = GetDataFromDGV(dgvWO);
                    if (checkBoxPending.Active)
                    {
                        data.Columns.RemoveAt(0);
                    }
                    // Display SaveFileDialog to save the Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save As Excel File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        ExcelServices.ExportData(data, saveFileDialog.FileName);
                        MessageBox.Show("Data saved to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private DataTable GetDataFromDGV(DataGridView dataGridView)
        {
            try
            {
                // Create a DataTable with the same columns as in the DataGridView
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    dataTable.Columns.Add(column.Name);
                }

                // Transfer data from DataGridView to DataTable
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }

                    dataTable.Rows.Add(dataRow);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }
        private void FormWORelationship_Load(object sender, EventArgs e)
        {
            ShowDataWoPending();
            cbCustomer.Items.AddRange(Common.CreateCustomer().Select(w => w.Value).Distinct().ToArray());
        }     
    
        private void txtUpdater_TextChanged(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Sort = this.dgvWO.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = this.dgvWO.FilterString;
        }

        private DataTable ToDataTableWOPending(List<WoChanging> data)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Customer");
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("Order No");
                dataTable.Columns.Add("Section");

                foreach (var item in data)
                {
                    var dataUsap = _usap.GetECO(item.ECO_NO);
                    DataRow row = dataTable.NewRow();
                    row["Customer"] = dataUsap == null ? "" : dataUsap.CUS_CODE.ToString();//ConvertShortCustomerName(dataUsap.CUS_CODE);
                    row["Model"] = dataUsap == null ? "" : dataUsap.PART_NO;
                    row["Order No"] = item.ORDER_NO;
                    row["Section"] = Common.GetType(item.TYPE_ID);
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

        private void insertWOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBoxPending.Active)
            {
                try
                {
                    if(selectedRow != null)
                    {
                        var orderNo = selectedRow.Cells["Order No"].Value;
                        FormInsertWO f = new FormInsertWO(orderNo);
                        f.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        DataGridViewRow selectedRow;
        private void dgvWO_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvWO.Rows[e.RowIndex];
            }
        }

        private void checkBoxPending_ValueChanged(object sender, bool value)
        {
            StartShowData();
        }

        public void StartShowData()
        {
            this.bindingSource1.Sort = null;
            this.bindingSource1.Filter = null;
            if (checkBoxPending.Active)
            {
                ShowDataWoPending();
            }
            else
            {
                ShowDataWoSuccess();
            }
        }

        private void ShowDataWoSuccess()
        {
            Common.StartFormLoading();
            dataWO = ToDataWORelationship(_woHelper.GetWORelationList().OrderBy(o => o.TYPE_NAME).ToList());
            DesignColumn(dataWO);
            Common.CloseFormLoading();
        }

        private void ShowDataWoPending()
        {
            Common.StartFormLoading();
            dataWO = ToDataTableWOPending(_woHelper.GetPendingWO().OrderBy(o => o.TYPE_NAME).ToList());
            DesignColumn(dataWO);
            Common.CloseFormLoading();
        }
        private void DesignColumn(DataTable dataTable)
        {
            this.bindingSource1.DataSource = dataTable;
            dgvWO.DataSource = this.bindingSource1.DataSource;
            dgvWO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWO.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
