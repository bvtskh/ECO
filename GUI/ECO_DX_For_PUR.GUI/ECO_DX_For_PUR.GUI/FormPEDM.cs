using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.DATA.Bussiness.EnumDefine;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormPEDM : Form
    {
        ExcelServices _excelService = new ExcelServices();
        IECO_PURCHASE _ecoHelper = new ECO_Helper();
        DataTable dataResult;
        bool IsCheckUpdate;

        public FormPEDM()
        {
            InitializeComponent();
        }

        private void FormPEDM_Load(object sender, EventArgs e)
        {
            cbSelectTypeSearch.SelectedIndex = 0;
            cbIssue.SelectedIndex = 0;
            dateTo.Value = DateTime.Now;
            dateFrom.Value = dateTo.Value.AddDays(-120);

        }

        bool btnaddClick = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!btnaddClick)
            {
                panelShowFormAdd.Visible = true;
                btnAdd.Image = Properties.Resources.minus;
                Common.AddFormToPanel(new FormInsertControlSheet(), panelShowFormAdd);
            }
            else
            {
                panelShowFormAdd.Visible = false;
                btnAdd.Image = Properties.Resources.add;
                Common.CloseForm("FormInsertControlSheet");
            }
            btnaddClick = !btnaddClick;

        }
        private void dgvPEDM_FilterStringChanged(object sender, EventArgs e)
        {
            try
            {
                this.bindingSourceECO.Filter = this.dgvPEDM.FilterString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPEDM_SortStringChanged(object sender, EventArgs e)
        {
            try
            {
                this.bindingSourceECO.Sort = this.dgvPEDM.SortString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } 

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }
        DataGridViewRow selectedRow;
        private void dgvPEDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvPEDM.Rows[e.RowIndex];                       
            }
        }

        private void uptoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow != null && selectedRow.Index != -1)
                {
                    int? id = Common.ConvertINT(selectedRow.Cells["Id"].Value);
                    if (id != null)
                    {
                        ECO_ControlSheet update = new ECO_ControlSheet();
                        update.Id = (int)id;
                        update.No = Common.ConvertINT(selectedRow.Cells["No"].Value);
                        update.ECN_ReceiveDate = Common.ConvertDate(selectedRow.Cells["ECN_ReceiveDate"].Value);
                        update.ECN_ERI_No = Common.ConvertString(selectedRow.Cells["ECN_ERI_No"].Value);
                        update.History = Common.ConvertString(selectedRow.Cells["History"].Value);
                        update.Ver_EE = Common.ConvertString(selectedRow.Cells["Ver_EE"].Value);
                        update.Ver_EA = Common.ConvertString(selectedRow.Cells["Ver_EA"].Value);
                        update.Apply = Common.ConvertString(selectedRow.Cells["Apply"].Value);
                        update.VE_Follows_ECN_CVN = Common.ConvertString(selectedRow.Cells["VE_Follows_ECN_CVN"].Value);
                        update.ECO_No = Common.ConvertString(selectedRow.Cells["ECO_No"].Value);
                        update.ModelName = Common.ConvertString(selectedRow.Cells["ModelName"].Value);
                        update.OldPartCode = Common.ConvertString(selectedRow.Cells["OldPartCode"].Value);
                        update.NewPartCode = Common.ConvertString(selectedRow.Cells["NewPartCode"].Value);
                        update.ContentOfChange = Common.ConvertString(selectedRow.Cells["ContentOfChange"].Value);
                        update.Location = Common.ConvertString(selectedRow.Cells["Location"].Value);
                        update.ProcessForAssembly = Common.ConvertString(selectedRow.Cells["ProcessForAssembly"].Value);
                        update.ECO_Issue = Common.ConvertString(selectedRow.Cells["ECO_Issue"].Value);
                        update.FAT_Implement = Common.ConvertString(selectedRow.Cells["FAT_Implement"].Value);
                        update.ImplementDate = Common.ConvertString(selectedRow.Cells["ImplementDate"].Value);
                        update.ShippingDate = Common.ConvertString(selectedRow.Cells["ShippingDate"].Value);
                        update.ECO_Status = Common.ConvertString(selectedRow.Cells["ECO_Status"].Value);
                        update.Confirm = Common.ConvertString(selectedRow.Cells["Confirm"].Value);
                        update.Issue_To = Common.ConvertString(selectedRow.Cells["Issue_To"].Value);
                        update.FATContentInformation = Common.ConvertString(selectedRow.Cells["FATContentInformation"].Value);
                        update.ModelFull = Common.ConvertString(selectedRow.Cells["ModelFull"].Value);
                        update.TVP_No = Common.ConvertString(selectedRow.Cells["TVP_No"].Value);
                        update.TVPResult = Common.ConvertString(selectedRow.Cells["TVPResult"].Value);
                        update.TVP_RecieveResultDate = Common.ConvertString(selectedRow.Cells["TVP_RecieveResultDate"].Value);
                        update.BOM_Change_When_ECO_Implement = Common.ConvertString(selectedRow.Cells["BOM_Change_When_ECO_Implement"].Value);
                        if (_ecoHelper.UpdateDataECOControlSheet(update))
                        {
                            MessageBox.Show("Update Success");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow != null && selectedRow.Index != -1)
                {
                    int? id = Common.ConvertINT(selectedRow.Cells["Id"].Value);
                    if (id != null)
                    {
                        if (_ecoHelper.RemoveControlsheetData((int)id))
                        {
                            MessageBox.Show("Delete Success");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        bool isAdvanced = false;
        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            if (!isAdvanced)
            {
                panelAdvanced.Visible = true;
            }
            else
            {
                panelAdvanced.Visible = false;
            }
            isAdvanced = !isAdvanced;
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            var resultData = CheckUpdate();
            if (resultData != null)
            {
                dataResult = resultData;
                this.bindingSourceECO.DataSource = dataResult;
                dgvPEDM.DataSource = this.bindingSourceECO.DataSource;
                dgvPEDM.Columns[11].HeaderText = "New part code";
                dgvPEDM.Columns[10].HeaderText = "Old part code";
                dgvPEDM.Columns[12].HeaderText = "Content of change";
                dgvPEDM.Columns[13].HeaderText = "Location";

                dgvPEDM.Columns[10].Name = "Old part code";
                dgvPEDM.Columns[11].Name = "New part code";
                dgvPEDM.Columns[12].Name = "Content of change";
                dgvPEDM.Columns[13].Name = "Location";
                Common.CloseFormLoading();
                MessageBox.Show($"{resultData.Rows.Count} new additional records");
            }
        }

        private DataTable CheckUpdate()
        {
            try
            {
                Common.StartFormLoading();
                IsCheckUpdate = true;
                ECO_ControlSheet controlSheetLastUpdate = _ecoHelper.GetLastControlSheetUpdate();
                DataTable dataControlSheetDM = ReverseDataTableRows(_excelService.ImportExcel(NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECOcontrolSheet)));
                var resultData = dataControlSheetDM.Clone();
                foreach (DataRow row in dataControlSheetDM.Rows)
                {
                    DateTime? date = Common.ConvertDate(row.Field<object>(1));
                    if (date == null) continue;
                    else
                    {
                        if (row == dataControlSheetDM.Rows[0]) // khi bản ghi cuối cùng trong controlsheet là bản ghi trong CSDL => chưa up bản ghi mới nào.
                        {
                            if (IsLastRow(controlSheetLastUpdate, row))
                            {
                                Common.CloseFormLoading();
                                MessageBox.Show("Newly added data not found");
                                return null;
                            }
                            else
                            {
                                resultData.ImportRow(row);
                                if (resultData.Rows.Count >= dataControlSheetDM.Rows.Count)
                                {
                                    Common.CloseFormLoading();
                                    MessageBox.Show("Newly added data not found");
                                    return null;
                                }
                            }
                        }
                    }                    
                }

                return resultData;
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();            
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
            finally
            {
                Common.CloseFormLoading();
            }
        }
        private bool IsLastRow(ECO_ControlSheet controlSheetLastUpdate, DataRow row)
        {
            try
            {
                int? No = Common.ConvertINT(row.Field<string>(0));
                DateTime? ECnReceiveDate = Common.ConvertDate(row.Field<string>(1));
                string ECN = Common.ConvertString(row.Field<string>(2));
                string ECO = Common.ConvertString(row.Field<string>(8));
                string Model = Common.ConvertString(row.Field<string>(9));
                if (No == controlSheetLastUpdate.No && ECnReceiveDate == controlSheetLastUpdate.ECN_ReceiveDate && ECN == controlSheetLastUpdate.ECN_ERI_No && ECO == controlSheetLastUpdate.ECO_No && Model == controlSheetLastUpdate.ModelName)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private DataTable ReverseDataTableRows(DataTable originalDataTable)
        {
            try
            {
                // Clone the structure of the original DataTable
                DataTable reversedDataTable = originalDataTable.Clone();

                // Add rows in reverse order
                for (int i = originalDataTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow originalRow = originalDataTable.Rows[i];
                    reversedDataTable.ImportRow(originalRow);
                }

                return reversedDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void contextSelectRow_Opening(object sender, CancelEventArgs e)
        {
            if (IsCheckUpdate)
            {
                contextSelectRow.Items[0].Visible = false;
                contextSelectRow.Items[1].Visible = false;
                contextSelectRow.Items[2].Visible = true;
            }
            else
            {
                contextSelectRow.Items[0].Visible = true;
                contextSelectRow.Items[1].Visible = true;
                contextSelectRow.Items[2].Visible = false;
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPEDM.RowCount > 0)
                {
                    List<ECO_ControlSheet> controlSheetList = new List<ECO_ControlSheet>();
                    for(int row = dgvPEDM.Rows.Count-1; row >= 0; row--)
                    {
                        ECO_ControlSheet controlSheet = new ECO_ControlSheet();
                        controlSheet.No = Common.ConvertINT(dgvPEDM.Rows[row].Cells[0].Value);
                        controlSheet.ECN_ReceiveDate = Common.ConvertDate(dgvPEDM.Rows[row].Cells[1].Value);
                        controlSheet.ECN_ERI_No = Common.ConvertString(dgvPEDM.Rows[row].Cells[2].Value);
                        controlSheet.History = Common.ConvertString(dgvPEDM.Rows[row].Cells[3].Value);
                        controlSheet.Ver_EE = Common.ConvertString(dgvPEDM.Rows[row].Cells[4].Value);
                        controlSheet.Ver_EA = Common.ConvertString(dgvPEDM.Rows[row].Cells[5].Value);
                        controlSheet.Apply = Common.ConvertString(dgvPEDM.Rows[row].Cells[6].Value);
                        controlSheet.VE_Follows_ECN_CVN = Common.ConvertString(dgvPEDM.Rows[row].Cells[7].Value);
                        controlSheet.ECO_No = Common.ConvertString(dgvPEDM.Rows[row].Cells[8].Value);
                        //if (controlSheet.ECO_No != null && _ecoHelper.IsExistedECN(controlSheet.ECO_No))
                        //{
                        //    //MessageBox.Show($"ECO/USR: {controlSheet.ECO_No} is Existed, Cannot insert");
                        //    //return;
                        //    continue;
                        //}
                        controlSheet.ModelName = Common.ConvertString(dgvPEDM.Rows[row].Cells[9].Value);
                        controlSheet.OldPartCode = Common.ConvertString(dgvPEDM.Rows[row].Cells[10].Value);
                        controlSheet.NewPartCode = Common.ConvertString(dgvPEDM.Rows[row].Cells[11].Value);
                        controlSheet.ContentOfChange = Common.ConvertString(dgvPEDM.Rows[row].Cells[12].Value);
                        controlSheet.Location = Common.ConvertString(dgvPEDM.Rows[row].Cells[13].Value);
                        controlSheet.ProcessForAssembly = Common.ConvertString(dgvPEDM.Rows[row].Cells[14].Value);
                        controlSheet.ECO_Issue = Common.ConvertString(dgvPEDM.Rows[row].Cells[15].Value);
                        controlSheet.FAT_Implement = Common.ConvertString(dgvPEDM.Rows[row].Cells[16].Value);
                        controlSheet.ImplementDate = Common.ConvertString(dgvPEDM.Rows[row].Cells[17].Value);
                        controlSheet.ShippingDate = Common.ConvertString(dgvPEDM.Rows[row].Cells[18].Value);
                        controlSheet.ECO_Status = Common.ConvertString(dgvPEDM.Rows[row].Cells[19].Value);
                        controlSheet.Confirm = Common.ConvertString(dgvPEDM.Rows[row].Cells[20].Value);
                        controlSheet.Issue_To = Common.ConvertString(dgvPEDM.Rows[row].Cells[21].Value);
                        controlSheet.FATContentInformation = Common.ConvertString(dgvPEDM.Rows[row].Cells[22].Value);
                        controlSheet.ModelFull = Common.ConvertString(dgvPEDM.Rows[row].Cells[23].Value);
                        controlSheet.TVP_No = Common.ConvertString(dgvPEDM.Rows[row].Cells[24].Value);
                        controlSheet.TVPResult = Common.ConvertString(dgvPEDM.Rows[row].Cells[25].Value);
                        controlSheet.TVP_RecieveResultDate = Common.ConvertString(dgvPEDM.Rows[row].Cells[26].Value);
                        controlSheet.BOM_Change_When_ECO_Implement = Common.ConvertString(dgvPEDM.Rows[row].Cells[27].Value);
                        controlSheetList.Add(controlSheet);
                    }
                    if (controlSheetList.Count > 0)
                    {
                        if (_ecoHelper.InsertControlsheetNewUpdate(controlSheetList))
                        {
                            MessageBox.Show("Insert Data Success full!");
                        }
                        _ecoHelper.InsertHistoryUpdateControlSheet(controlSheetList.Last().Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            try
            {
                IsCheckUpdate = false;
                ClearFilterBindingSource();
                Common.StartFormLoading();
                int indexType = cbSelectTypeSearch.SelectedIndex;
                if (indexType != -1)
                {
                    if (indexType == (int)PE_DM_Enum.SelectType.Duplicate_ECO)
                    {
                        ShowDuplicateUSR();
                        return;
                    }
                    else
                    {
                        if (cbIssue.SelectedIndex == (int)PE_DM_Enum.Issue.PURCHASE)
                        {
                            IEnumerable<ECO_ControlSheet> dataIssueToPur = _ecoHelper.GetDataIssueToPur(dateFrom.Value,dateTo.Value);
                            if (string.IsNullOrEmpty(txtSearchContent.Text))
                            {
                                dataResult = _ecoHelper.GetDataControlSheet(dataIssueToPur, intBox.Value);
                                this.bindingSourceECO.DataSource = dataResult;
                                dgvPEDM.DataSource = this.bindingSourceECO.DataSource;
                            }
                            else
                            {
                                dgvPEDM.DataSource = _ecoHelper.GetDataECOcontrolsheetSearch(indexType, txtSearchContent.Text);
                            }
                        }
                        else if (cbIssue.SelectedIndex == (int)PE_DM_Enum.Issue.ALL)
                        {
                            if (string.IsNullOrEmpty(txtSearchContent.Text))
                            {
                                dataResult = _ecoHelper.GetDataControlSheet(intBox.Value, dateFrom.Value, dateTo.Value);
                                this.bindingSourceECO.DataSource = dataResult;
                                dgvPEDM.DataSource = this.bindingSourceECO.DataSource;
                            }
                            else
                            {
                                dgvPEDM.DataSource = _ecoHelper.GetDataECOcontrolsheetSearch(indexType, txtSearchContent.Text);
                            }
                        }
                    }                          
                }
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                CustomDgv();
                Common.CloseFormLoading();
            }
        }

        private void ShowDuplicateUSR()
        {
            dataResult = _ecoHelper.GetDuplicateECO(dateFrom.Value, dateTo.Value);
            this.bindingSourceECO.DataSource = dataResult;
            dgvPEDM.DataSource = this.bindingSourceECO.DataSource;;
            Common.CloseFormLoading();
            CustomDgv();
            MessageBox.Show($"{dataResult.Rows.Count} duplicate record");
        }

        private void ClearFilterBindingSource()
        {
            this.bindingSourceECO.Sort = null;
            this.bindingSourceECO.Filter = null;
        }

        private void CustomDgv()
        {
            try
            {
                dgvPEDM.Columns["Id"].Visible = false;
                dgvPEDM.Columns["ECN_ReceiveDate"].HeaderText = "Receive Date";
                dgvPEDM.Columns["ECN_ERI_No"].HeaderText = "ECN\\ERI No";
                dgvPEDM.Columns["VE_Follows_ECN_CVN"].HeaderText = "VE theo ECN\\CVN";
                dgvPEDM.Columns["ECO_No"].HeaderText = "ECO No";
                dgvPEDM.Columns["OldPartCode"].HeaderText = "Old Part";
                dgvPEDM.Columns["NewPartCode"].HeaderText = "New Part";
                dgvPEDM.Columns["ContentOfChange"].HeaderText = "Content Of Change";
                dgvPEDM.Columns["ECO_Issue"].HeaderText = "ECO Issue";
                dgvPEDM.Columns["FAT_Implement"].HeaderText = "FAT Implement";
                dgvPEDM.Columns["ImplementDate"].HeaderText = "Implement Date";
                dgvPEDM.Columns["ShippingDate"].HeaderText = "Shipping Date";
                dgvPEDM.Columns["ECO_Status"].HeaderText = "ECO Status";
                dgvPEDM.Columns["Issue_To"].HeaderText = "Issue To";
                dgvPEDM.Columns["FATContentInformation"].HeaderText = "Nội dung FAT thực hiện";
                dgvPEDM.Columns["TVP_No"].HeaderText = "TVP No";
                dgvPEDM.Columns["TVPResult"].HeaderText = "Kết quả TVP";
                dgvPEDM.Columns["TVP_RecieveResultDate"].HeaderText = "Ngày nhận kết quả TVP";
                dgvPEDM.Columns["BOM_Change_When_ECO_Implement"].HeaderText = "Thay đổi BOM khi ECO thực hiện";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void txtSearchContent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }
    }
}
