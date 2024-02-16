using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ECO_DX_For_PUR.Utils;
using System.IO;
using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using Sunny.UI;
using ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository;
using System.Reflection;
using ECO_DX_For_PUR.DATA.Bussiness.EnumDefine;
//using PI_Lib;
using System.ComponentModel;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormPurchase : Form
    {

        ExcelServices _excelService = new ExcelServices();
        PurchaseAction_Repository _purchaseAction = new PurchaseAction_Repository();
        USAPService.USAPWebServiceSoapClient _usap = new USAPService.USAPWebServiceSoapClient();

        IECO_PURCHASE _ecoHelper = new ECO_Helper();

        private int indexSelectType;
        
        static List<string> ECNaction = new List<string>();

        DataTable dataPending;
        DataTable dataFinish;
        DataTable dataPurDuplicate;

        //
        public FormPurchase()
        {
            InitializeComponent();
            dateTo.Value = DateTime.Now;
            dateFrom.Value = dateTo.Value.AddDays(-120);
            indexSelectType = (int)PUR_Enum.SelectType.Pending;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectType == (int)PUR_Enum.SelectType.Pending)
                {
                    this.bindingPending.Filter = this.dgvPurchase.FilterString;
                }
                else if (indexSelectType == (int)PUR_Enum.SelectType.Finish)
                {
                    this.bindingFinish.Filter = this.dgvPurchase.FilterString;
                }
                else if (indexSelectType == (int)PUR_Enum.SelectType.Duplicate)
                {
                    this.bindingDuplicate.Filter = this.dgvPurchase.FilterString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            try
            {
                if (indexSelectType == (int)PUR_Enum.SelectType.Pending)
                {
                    this.bindingPending.Sort = this.dgvPurchase.SortString;
                }
                else if (indexSelectType == (int)PUR_Enum.SelectType.Finish)
                {
                    this.bindingFinish.Sort = this.dgvPurchase.SortString;
                }
                else if (indexSelectType == (int)PUR_Enum.SelectType.Duplicate)
                {
                    this.bindingDuplicate.Sort = this.dgvPurchase.SortString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public DataTable ResultDataFinished(DataTable dataMaster, List<Purchase_Action> afterFilter)
        {
            try
            {
                ECO_ControlSheet controlSheetExist = new ECO_ControlSheet();
                foreach (var item in afterFilter)
                {
                    dataMaster.Rows.Add();
                    DataRow rows = dataMaster.Rows[dataMaster.Rows.Count - 1];
                    if (item.ECO_ControlSheet_Id == null)
                    {
                        controlSheetExist = null;
                    }
                    else
                    {
                        controlSheetExist = _ecoHelper.GetECOcontrolSheetByID((int)item.ECO_ControlSheet_Id);
                    }

                    rows["Thời gian thực hiện"] = ConvertDate(item.Action_Date);// ngay luu action
                    rows["Ngày phát hành"] = ConvertDate(item.ReleaseDate);// ngay phat hanh
                    rows["ECN"] = item.ECN; // ECN
                    rows["ECO No"] = item.ECO_No; // ECO
                    rows["Model"] = controlSheetExist == null ? "" : controlSheetExist.ModelName;
                    rows["Current part"] = item.Old_Part_BOM1; //old part
                    rows["New part"] = item.New_Part; // new part
                    rows["Current price"] = item.Old_Price == 0 || item.Old_Price == null ? "#N/A" : item.Old_Price.ToString();
                    rows["New price"] = item.New_Price == 0 || item.New_Price == null ? "#N/A" : item.New_Price.ToString(); ;
                    rows["different"] = CheckDifferent(item.Old_Price, item.New_Price);
                    rows["Current Vendor"] = item.Old_Vendor;
                    rows["New Vendor"] = item.New_Vendor;
                    rows["Location"] = controlSheetExist == null ? "" : controlSheetExist.Location;
                    rows["ECO content"] = controlSheetExist == null ? "" : controlSheetExist.ContentOfChange;
                    rows["Situation"] = item.Report;
                    rows["TVP No"] = controlSheetExist == null ? "" : controlSheetExist.TVP_No;
                    rows["TVP result"] = controlSheetExist == null ? "" : controlSheetExist.TVPResult;
                    rows["Reason"] = item.Reason;
                    rows["ETA UMCVN"] = item.ETA_UMCVN;
                    rows["Est using new part date"] = item.Est_Using_NewPart_Date;
                    rows["Transfered ECO date"] = item.Transfered_ECO_Date;
                    rows["Purpose Transferd ECO"] = "";
                    rows["Received ECO date"] = "";
                    rows["1st delivery"] = "";
                    rows["Action"] = "";
                }
                return dataMaster;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private string CheckReport(decimal? oldPrice, decimal? newPrice)
        {
            if ((oldPrice != null && newPrice != null) && (oldPrice > 0 && newPrice > 0))
            {
                if (oldPrice == newPrice)
                {
                    return "No apply-same price";
                }
                else if (oldPrice < newPrice)
                {
                    return "No apply-high price";
                }
                else
                {
                    return "";
                }
            }
            return "";
        }

        private string CheckDifferent(double? oldPrice, double? newPrice)
        {
            if (oldPrice > 0 && newPrice > 0)
            {
                if (oldPrice - newPrice > 0)
                {
                    return $"({Math.Abs(Math.Round((double)oldPrice - (double)newPrice, 4))})";
                }
                else
                    return $"{Math.Abs(Math.Round((double)oldPrice - (double)newPrice, 4))}";
            }
            else
            {
                return "#N/A";
            }
        }

        private bool IsAvalidSize(string filePath)
        {
            if (File.Exists(filePath))
            {
                // Create a FileInfo object
                FileInfo fileInfo = new FileInfo(filePath);

                // Get the file size in bytes
                long fileSizeInBytes = fileInfo.Length;

                // Convert bytes to kilobytes (1 KB = 1024 bytes)
                double fileSizeInKB = fileSizeInBytes / 1024.0;

                // Convert bytes to megabytes (1 MB = 1024 KB)
                double fileSizeInMB = fileSizeInKB / 1024.0;

                Console.WriteLine($"File Size: {fileSizeInBytes} bytes ({fileSizeInKB:F2} KB, {fileSizeInMB:F2} MB)");
                if (fileSizeInMB <= 20)
                {
                    return true;
                }
                return false;
            }
            else
            {
                Console.WriteLine("File not found.");
                return false;
            }
        }


        private string FindOldPartByModelAndLocation(DataTable dataSAP, string model, string location)
        {
            foreach (DataRow row in dataSAP.Rows)
            {
                string rowModel = row.Field<string>(0);
                string rowLocation = row.Field<string>(10);
                string rowOldpart = row.Field<string>(2);
                if (rowLocation == null) continue;
                // Compare the values
                if (rowModel.Contains(model) && (rowLocation == location || location.Contains(rowLocation)))
                {
                    return rowOldpart; // Return the value in the 5th cell if the conditions are met
                }
            }

            return "Not found"; // Return a default value if no match is found
        }

        private string ConvertDate(object stringDate)
        {
            DateTime result;
            if (stringDate != null)
            {
                if (DateTime.TryParse(stringDate.ToString(), out result))
                {
                    return result.Date.ToString("MM/dd/yyyy");
                };
            }
            return null;
        }

        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null && e.Value.ToString().Contains("("))
            {
                // Apply custom formatting (changing the text color to red)
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var dataECO = _excelService.ImportExcel(NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECOcontrolSheet));
                List<ECO_ControlSheet> controlSheetList = new List<ECO_ControlSheet>();
                foreach (DataRow row in dataECO.Rows)
                {
                    ECO_ControlSheet controlSheet = new ECO_ControlSheet();

                    controlSheet.No = Int16.Parse(row.Field<string>(0).Trim());
                    controlSheet.ECN_ReceiveDate = ConvertDates(row.Field<string>(1).Trim());
                    controlSheet.ECN_ERI_No = ConvertString(row.Field<string>(2));
                    controlSheet.History = ConvertString(row.Field<string>(3));
                    controlSheet.Ver_EE = ConvertString(row.Field<string>(4));
                    controlSheet.Ver_EA = ConvertString(row.Field<string>(5));
                    controlSheet.Apply = ConvertString(row.Field<string>(6));
                    controlSheet.VE_Follows_ECN_CVN = ConvertString(row.Field<string>(7));
                    controlSheet.ECO_No = ConvertString(row.Field<string>(8));
                    controlSheet.ModelName = ConvertString(row.Field<string>(9));
                    controlSheet.OldPartCode = ConvertString(row.Field<string>(10));
                    controlSheet.NewPartCode = ConvertString(row.Field<string>(11));
                    controlSheet.ContentOfChange = ConvertString(row.Field<string>(12));
                    controlSheet.Location = ConvertString(row.Field<string>(13));
                    controlSheet.ProcessForAssembly = ConvertString(row.Field<string>(14));
                    controlSheet.ECO_Issue = ConvertString(row.Field<string>(15));
                    controlSheet.FAT_Implement = ConvertString(row.Field<string>(16));
                    controlSheet.ImplementDate = ConvertString(row.Field<string>(17));
                    controlSheet.ShippingDate = ConvertString(row.Field<string>(18));
                    controlSheet.ECO_Status = ConvertString(row.Field<string>(19));
                    controlSheet.Confirm = ConvertString(row.Field<string>(20));
                    controlSheet.Issue_To = ConvertString(row.Field<string>(21));
                    controlSheet.FATContentInformation = ConvertString(row.Field<string>(22));
                    controlSheet.ModelFull = ConvertString(row.Field<string>(23));
                    controlSheet.TVP_No = ConvertString(row.Field<string>(24));
                    controlSheet.TVPResult = ConvertString(row.Field<string>(25));
                    controlSheet.TVP_RecieveResultDate = ConvertString(row.Field<string>(26));
                    controlSheet.BOM_Change_When_ECO_Implement = ConvertString(row.Field<string>(27));
                    controlSheetList.Add(controlSheet);

                }
                if (_ecoHelper.InsertData(controlSheetList))
                {
                    MessageBox.Show("Insert Data Success full!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private DateTime? ConvertDates(string str)
        {
            DateTime result;
            if (str != null)
            {
                if (DateTime.TryParse(str.ToString(), out result))
                {
                    return result;
                };
            }
            return null;
        }

        private string ConvertString(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return null;
            return str.Trim();
        }

        private void purchaseActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ECNaction != null && ECNaction.Count > 0)
                {
                    FormPurchaseAction f = new FormPurchaseAction();
                    f.ECN_No = string.Join(",", ECNaction);
                    f.Show();
                }
                else
                {
                    FormPurchaseAction f = new FormPurchaseAction();
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        DataGridViewRow selectedRow;
        private void dgvECNSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvPurchase.Rows[e.RowIndex];
            }
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            cbSelectType.SelectedIndex = (int)PUR_Enum.SelectType.Pending;
            cbSearch.SelectedIndex = (int)PUR_Enum.SearchBy.ECN;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            try
            {
                Common.StartFormLoading();                
                ResetBindingSource();
                List<ECO_ControlSheet> controlSheetResult = new List<ECO_ControlSheet>();
                List<Purchase_Action> purChaseResult = new List<Purchase_Action>();
                List<Purchase_Action> purActionDuplicate = new List<Purchase_Action>();

                if (cbSelectType.SelectedIndex == (int)PUR_Enum.SelectType.Pending) // nếu chọn chưa action
                {
                    SetCurrentSelectType((int)PUR_Enum.SelectType.Pending);                    
                    try
                    {
                        ECNaction.Clear();
                        List<ECO_ControlSheet> controlSheetPending = _ecoHelper.GetECNPending().OrderByDescending(o=>o.Id).ToList();
                        dataPending = GetDataPending(controlSheetPending);
                        this.bindingPending.DataSource = dataPending;
                        dgvPurchase.DataSource = this.bindingPending.DataSource;
                        CustomDgv();                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }                                       
                }
                else if (cbSelectType.SelectedIndex == (int)PUR_Enum.SelectType.Finish)////////
                {
                    indexSelectType = 0;
                    // danh sach purchase da action
                    var purchaseActed = _ecoHelper.GetDataPurchaseAction(dateFrom.Value,dateTo.Value);
                    if (!string.IsNullOrEmpty(txtSearchString.Text))// nếu có nội dung tìm kiếm.
                    {
                        if (cbSearch.SelectedIndex == 0) // nếu chọn tìm theo ECN
                        {
                            purChaseResult = purchaseActed.Where(w => w.ECN !=null && w.ECN.Contains(txtSearchString.Text)).ToList();
                        }
                        else if (cbSearch.SelectedIndex == 1) // nếu chọn tìm theo ECO
                        {
                            purChaseResult = purchaseActed.Where(w =>w.ECO_No !=null && w.ECO_No.Contains(txtSearchString.Text)).ToList();
                        }
                    }
                    else // ko co noi dung tim kiem
                    {
                        purChaseResult = purchaseActed.Take(intBox.Value).ToList();
                    }

                    DataTable dataMaster = Datatable_Common.CreateColumnFinishAction();/*_excelService.GetColumnHeader(Common.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseMaster));*/
                    var dataResult =  ResultDataFinished(dataMaster, purChaseResult);
                    dataFinish = dataResult;
                    this.bindingFinish.DataSource = dataFinish;
                    dgvPurchase.DataSource = this.bindingFinish.DataSource;
                }
                else if(cbSelectType.SelectedIndex == 2)
                {
                    indexSelectType = 2;
                    // lay danh sach ECO trung nhau.
                    var ECOlist = _purchaseAction.GetDuplicateECO(dateFrom.Value, dateTo.Value);
                    if (!string.IsNullOrEmpty(txtSearchString.Text))// nếu có nội dung tìm kiếm.
                    {
                        if (cbSearch.SelectedIndex == 0) // nếu chọn tìm theo ECN
                        {
                            purActionDuplicate = ECOlist.Where(w => w.ECN !=null && w.ECN.Contains(txtSearchString.Text)).ToList();
                        }
                        else if (cbSearch.SelectedIndex == 1) // nếu chọn tìm theo ECO
                        {
                            purActionDuplicate = ECOlist.Where(w => w.ECO_No != null && w.ECO_No.Contains(txtSearchString.Text)).ToList();
                        }
                    }
                    else // ko co noi dung tim kiem
                    {
                        purActionDuplicate = ECOlist.Take(intBox.Value).ToList();
                    }
                    DataTable dataMaster = Datatable_Common.CreateColumnFinishAction();
                    var dataResult = ResultDataFinished(dataMaster, purActionDuplicate);

                    dataPurDuplicate = dataResult;
                    this.bindingDuplicate.DataSource = dataPurDuplicate;
                    dgvPurchase.DataSource = this.bindingDuplicate.DataSource;
                }
               Common.SetDoubleBuffering(dgvPurchase, true);
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                
                Common.CloseFormLoading();
            }
        }

        private DataTable GetDataPending(List<ECO_ControlSheet> pending)
        {
            List<ECO_ControlSheet> pendingResult = new List<ECO_ControlSheet>();
            if (!string.IsNullOrEmpty(txtSearchString.Text))// nếu có nội dung tìm kiếm.
            {
                if (cbSearch.SelectedIndex == (int)PUR_Enum.SearchBy.ECN) // nếu chọn tìm theo ECN
                {
                    pendingResult = pending.Where(w => w.ECN_ERI_No != null && w.ECN_ERI_No.Contains(txtSearchString.Text)).ToList();
                }
                else if (cbSearch.SelectedIndex == (int)PUR_Enum.SearchBy.ECO) // nếu chọn tìm theo ECO
                {
                    pendingResult = pending.Where(w => w.ECO_No != null && w.ECO_No.Contains(txtSearchString.Text)).ToList();
                }
            }
            else // ko co noi dung tim kiem
            {
                pendingResult = pending;//.Take(intBox.Value).ToList();
            }
            // tạo cột select

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "#";
            checkBoxColumn.Name = "checkBoxColumn";
            dgvPurchase.Columns.Add(checkBoxColumn);
            dataPending = CreatePendingDataTable();
            dataPending = PopulateDataTable(dataPending, pendingResult);           

            if (ECNaction.Count > 0)
            {
                foreach (var item in ECNaction)
                {
                    var row = dgvPurchase.Rows.Cast<DataGridViewRow>().Where(w => w.Cells["ECN_ERI_No"].Value != null && w.Cells["ECN_ERI_No"].Value.ToString() == item).FirstOrDefault();
                    if (row != null)
                    {
                        DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvPurchase.Rows[row.Index].Cells[0];
                        checkboxCell.Value = true;
                    }
                }
            }
            return dataPending;
        }

        private void SetCurrentSelectType(int index)
        {
            indexSelectType = index;
        }

        private void ResetBindingSource()
        {
            dgvPurchase.DataSource = null;
            dgvPurchase.Columns.Clear();
            this.bindingPending.Sort = null;
            this.bindingPending.Filter = null;
            this.bindingFinish.Sort = null;
            this.bindingFinish.Filter = null;
            this.bindingDuplicate.Sort = null;
            this.bindingDuplicate.Filter = null;
        }

        private void CustomDgv()
        {
            dgvPurchase.Columns["Id"].Visible = false;
            dgvPurchase.Columns["No"].Visible = false;
            dgvPurchase.Columns["ECN_ReceiveDate"].HeaderText = "Receive Date";
            dgvPurchase.Columns["ECN_ERI_No"].HeaderText = "ECN\\ERI No";
            dgvPurchase.Columns["VE_Follows_ECN_CVN"].HeaderText = "VE theo ECN\\CVN";
            dgvPurchase.Columns["ECO_No"].HeaderText = "ECO No";
            dgvPurchase.Columns["OldPartCode"].HeaderText = "Old Part";
            dgvPurchase.Columns["NewPartCode"].HeaderText = "New Part";
            dgvPurchase.Columns["ContentOfChange"].HeaderText = "Content Of Change";
            dgvPurchase.Columns["ECO_Issue"].HeaderText = "ECO Issue";
            dgvPurchase.Columns["FAT_Implement"].HeaderText = "FAT Implement";
            dgvPurchase.Columns["ImplementDate"].HeaderText = "Implement Date";
            dgvPurchase.Columns["ShippingDate"].HeaderText = "Shipping Date";
            dgvPurchase.Columns["ECO_Status"].HeaderText = "ECO Status";
            dgvPurchase.Columns["Issue_To"].HeaderText = "Issue To";
            dgvPurchase.Columns["FATContentInformation"].HeaderText = "Nội dung FAT thực hiện";
            dgvPurchase.Columns["TVP_No"].HeaderText = "TVP No";
            dgvPurchase.Columns["TVPResult"].HeaderText = "Kết quả TVP";
            dgvPurchase.Columns["TVP_RecieveResultDate"].HeaderText = "Ngày nhận kết quả TVP";
            dgvPurchase.Columns["BOM_Change_When_ECO_Implement"].HeaderText = "Thay đổi BOM khi ECO thực hiện";
            dgvPurchase.Columns["ECO_No"].DisplayIndex = 5;
            dgvPurchase.Columns["ModelName"].DisplayIndex = 6;
            dgvPurchase.Columns["OldPartCode"].DisplayIndex = 7;
            dgvPurchase.Columns["NewPartCode"].DisplayIndex = 8;
            dgvPurchase.Columns["Location"].DisplayIndex = 9;
            dgvPurchase.Columns["ContentOfChange"].DisplayIndex = 10;

            dgvPurchase.Columns[0].Width = 20;
        }

        private void dgvECNSetting_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPurchase.IsCurrentCellDirty)
            {
                dgvPurchase.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvECNSetting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is in the checkbox column
                if (indexSelectType == 1) // controlsheet
                {
                    if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                    {
                        DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvPurchase.Rows[e.RowIndex].Cells[0];

                        // Check if the checkbox is checked
                        bool isChecked = (bool)checkboxCell.EditedFormattedValue;

                        if (isChecked)
                        {
                            DataGridViewRow rowData = (DataGridViewRow)dgvPurchase.Rows[e.RowIndex];
                            if (rowData.Cells["ECN_ERI_No"].Value != null)
                            {
                                if (!ECNaction.Contains(rowData.Cells["ECN_ERI_No"].Value.ToString()))
                                {
                                    ECNaction.Add(rowData.Cells["ECN_ERI_No"].Value.ToString());
                                }
                            }
                        }
                        else
                        {
                            DataGridViewRow rowData = (DataGridViewRow)dgvPurchase.Rows[e.RowIndex];
                            if (rowData.Cells["ECN_ERI_No"].Value != null)
                            {
                                if (ECNaction.Contains(rowData.Cells["ECN_ERI_No"].Value.ToString()))
                                {
                                    ECNaction.Remove(rowData.Cells["ECN_ERI_No"].Value.ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        bool isAdvancedClick =false;

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            if (!isAdvancedClick)
            {
                panelAdvanced.Visible = true;
            }
            else
            {
                panelAdvanced.Visible = false;
            }
            isAdvancedClick = !isAdvancedClick;
        }

        private void dgvECNSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming your checkbox column index is 0 (adjust as per your actual index)
            int checkboxColumnIndex = 0;

            // Check if the changed cell is in the checkbox column
            if (e.ColumnIndex == checkboxColumnIndex && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dgvPurchase.Rows[e.RowIndex].Cells[checkboxColumnIndex];

                // Set the background color for the entire row based on the checkbox value
                if (Convert.ToBoolean(checkboxCell.Value))
                {
                    dgvPurchase.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; // Change the color as needed
                }
                else
                {
                    dgvPurchase.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvPurchase.DefaultCellStyle.BackColor;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var data =_excelService.ImportExcel("C:\\Users\\U42107\\Desktop\\ThanhDX\\Thanh_Project\\Thanh_Project\\ECO DX for PUR\\zmm80_CANON_1122.xlsx");
            //List<PUR_ZMM80> zmm80List = new List<PUR_ZMM80>();
            //foreach(DataRow item in data.Rows)
            //{
            //    string meterial = ConvertString( item.Field<object>(0));
            //    DateTime? date = ConvertDate(item.Field<object>(21));
            //    PUR_ZMM80 zmm80 = new PUR_ZMM80();
            //    zmm80.INTERNAL_MATERIAL = meterial;
            //    zmm80.ETA_FACTORY_DATE = date;
            //    zmm80List.Add(zmm80);
            //}
            //_repositoryZMM80.InsertZMM80(zmm80List);
            //_repositoryZMM80.Count();
        }

        private void txtSearchString_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }
        private DataTable CreatePendingDataTable()
        {
            DataTable dataTable = new DataTable("Pending");
            ECO_ControlSheet _ControlSheet = new ECO_ControlSheet();
            foreach (PropertyInfo propertyInfo in _ControlSheet.GetType().GetProperties())
            {
                dataTable.Columns.Add(propertyInfo.Name, typeof(string));
            }

            return dataTable;
        }
        private DataTable PopulateDataTable(DataTable dataTable, List<ECO_ControlSheet> controlSheet)
        {
            foreach (var item in controlSheet)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = item.Id;
                row["No"] = item.No;
                row["ECN_ReceiveDate"] = Common.ConvertDate(item.ECN_ReceiveDate);
                row["ECN_ERI_No"] = item.ECN_ERI_No;
                row["History"] = item.History;
                row["Ver_EE"] = item.Ver_EE;
                row["Ver_EA"] = item.Ver_EA;
                row["Apply"] = item.Apply;
                row["VE_Follows_ECN_CVN"] = item.VE_Follows_ECN_CVN;
                row["ECO_No"] = item.ECO_No;
                row["ModelName"] = item.ModelName;
                row["OldPartCode"] = item.OldPartCode;
                row["NewPartCode"] = item.NewPartCode;
                row["ContentOfChange"] = item.ContentOfChange;
                row["Location"] = item.Location;
                row["ProcessForAssembly"] = item.ProcessForAssembly;
                row["ECO_Issue"] = item.ECO_Issue;
                row["FAT_Implement"] = item.FAT_Implement;
                row["ImplementDate"] = item.ImplementDate;
                row["ShippingDate"] = item.ShippingDate;
                row["ECO_Status"] = item.ECO_Status;
                row["Confirm"] = item.Confirm;
                row["Issue_To"] = item.Issue_To;
                row["FATContentInformation"] = item.FATContentInformation;
                row["ModelFull"] = item.ModelFull;
                row["TVP_No"] = item.TVP_No;
                row["TVPResult"] = item.TVPResult;
                row["TVP_RecieveResultDate"] = item.TVP_RecieveResultDate;
                row["BOM_Change_When_ECO_Implement"] = item.BOM_Change_When_ECO_Implement;
                dataTable.Rows.Add(row);
            }           
            return dataTable;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbSelectType.SelectedIndex == 0 || cbSelectType.SelectedIndex == 2)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = true;
            }
            else if (cbSelectType.SelectedIndex == 1)
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
            }

        }

        private void selectECNFinishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectFinishECN f = new FormSelectFinishECN();
            f.Show();
        }

        private void pPDFECOChangeNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the content of the "Id" column for the selected row
                if (selectedRow != null)
                {
                    object eco = null;
                    if (indexSelectType == 1)
                    {
                        if(selectedRow.Cells["ECO_No"] != null)
                        {
                            eco = selectedRow.Cells["ECO_No"].Value;
                        }                        
                    }
                    else if (indexSelectType == 0 || indexSelectType ==2)
                    {
                        if (selectedRow.Cells["ECO No"] != null)
                        {
                            eco = selectedRow.Cells["ECO No"].Value;
                        }
                    }
                    if (eco != null)
                    {
                        try
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
                        catch (NullReferenceException)
                        {
                            MessageBox.Show($"PDF not found for USR: {eco.ToString()}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}