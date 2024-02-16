using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.DATA.PI_BASE.Repository;
using ECO_DX_For_PUR.Utils;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormPurchaseAction : Form
    {
        PurchaseAction_Repository _purchaseAction = new PurchaseAction_Repository();
        ExcelServices _excelService = new ExcelServices();
        PI_BASE_Repository _pI_BASE_Repository = new PI_BASE_Repository();
        DataTable dataAction;
        public string ECN_No {get;set;}
        public FormPurchaseAction()
        {
            InitializeComponent();
            cbSituation.Font = new Font("Tahoma", 9.75F, FontStyle.Regular);
        }

        private void FormPurchaseAction_Load(object sender, EventArgs e)
        {
            if(ECN_No != null)
            {
                txtECN.Text = ECN_No;
                PurchaseAction(ECN_No);
            }
        }

        private void PurchaseAction(string eCN_No)
        {
            try
            {
                Common.StartFormLoading();
                dgvAction.DataSource = null;
                dgvAction.Columns.Clear();
                //string ECNText = ecn.Text;
                dataAction = _purchaseAction.GetDataPurchaseAction(eCN_No); // danh sach sau khi filter tu controlsheet
                                                                                 // lay header Text column tu format co san
                this.bindingAction.DataSource = dataAction;
                dgvAction.DataSource = this.bindingAction.DataSource;
                dgvAction.Columns["ECO Control Sheet ID"].Visible = false;
                // Freeze the first three columns
                for (int i = 0; i < 5; i++)
                {
                    dgvAction.Columns[i].Frozen = true;
                }
                FilterRowRuningChangeAndETA(dgvAction.Rows);
                //BC tô màu
                //CustomColorBC(23,22,21);
                //CustomColorPurAction(20, 19, 18,17,16,15,14,13);
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

        private void FilterRowRuningChangeAndETA(DataGridViewRowCollection rows)
        {
            foreach(DataGridViewRow row in rows)
            {
                object cellValue = row.Cells["ETA UMCVN"].Value;
                object cellRunnigchange = row.Cells["New part"].Value;
                object cellNoUsePart = row.Cells["Situation"].Value;
                if(cellNoUsePart !=null && cellNoUsePart.ToString() == "No apply-child part no use this model")
                {
                    row.Cells["Current part(BOM 1)"].Style.BackColor = Color.DeepPink;
                }


                if (cellRunnigchange != null && _purchaseAction.IsrunningChnage(cellRunnigchange.ToString()))
                {
                    row.Cells["New part"].Style.BackColor = Color.LightGreen;
                    row.Cells["Situation"].Value = "Have schedule apply already-running change";
                }
                // If the value is not null or empty, set the background color of the entire row to red
                //if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()) && IsEATOKDate(cellValue))
                //{
                //    row.DefaultCellStyle.BackColor = Color.LightGreen; // an toan
                //}
                //if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()) && IsEATNGDate(cellValue))
                //{
                //    row.DefaultCellStyle.BackColor = Color.LightCoral; // het han
                //}
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()) && IsEATAlarmDate(cellValue))
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen; // 7 ngay
                }
            }                     
        }

        private void CustomColorPurAction(params int[] columns)
        {
            foreach (var column in columns)
            {
                dgvAction.Columns[column].HeaderCell.Style.BackColor = Color.Firebrick;
                dgvAction.Columns[column].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void CustomColorBC(params int[] columns)
        {
            foreach(var column in columns)
            {
                dgvAction.Columns[column].HeaderCell.Style.BackColor = Color.Khaki;
                dgvAction.Columns[column].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private int GetIndex(DataGridViewComboBoxCell cells, string content)
        {
            int index = cells.Items.IndexOf(content);
            return index;
        }



        private void ClearDatagridView()
        {
            dgvAction.DataSource = null;
            dgvAction.Rows.Clear();
            dgvAction.Columns.Clear();
            dgvAction.Refresh();
        }

        private void dgvAction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == dgvAction.Columns["Different"].Index && e.Value != null && e.Value.ToString().Contains("("))
            //{
            //    // Apply custom formatting (changing the text color to red)
            //    e.CellStyle.ForeColor = Color.Red;
            //}
        }

        private bool IsEATAlarmDate(object cellValue)
        {
            DateTime date;
            if (cellValue != null)
            {
                if (DateTime.TryParse(cellValue.ToString(), out date))
                {
                    if (date >= DateTime.Now && date <= DateTime.Now.AddDays(10))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsEATNGDate(object cellValue)
        {
            DateTime date;
            if (cellValue != null)
            {
                if (DateTime.TryParse(cellValue.ToString(), out date))
                {
                    if (date < DateTime.Now)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsEATOKDate(object value)
        {
            DateTime date;
            if(value != null)
            {
                if (DateTime.TryParse(value.ToString(), out date))
                {
                    if(date >= DateTime.Now && ( date <= DateTime.Now.AddDays(7) || date>= DateTime.Now.AddDays(7)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private DataTable GetDataFromDGV()
        {
            try
            {
                // Create a DataTable with the same columns as in the DataGridView
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dgvAction.Columns)
                {
                    dataTable.Columns.Add(column.Name);
                }

                // Transfer data from DataGridView to DataTable
                foreach (DataGridViewRow row in dgvAction.Rows)
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

        private void btnMultiSelect_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem option1 = new ToolStripMenuItem("Multiple ECN Export");
            ToolStripMenuItem option2 = new ToolStripMenuItem("Update ECO/USR");
            menu.Items.Add(option1);
            menu.Items.Add(option2);
            menu.Items[0].Image = Properties.Resources.multiple;
            menu.Items[1].Image = Properties.Resources.update;
            menu.Show(btnMultiSelect, new Point(0, btnMultiSelect.Height));
            option1.Click += Option1_Click;
            option2.Click += Option2_Click;
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            var filePath = _excelService.GetExelFilePath();
            if (!_excelService.CheckFormat(filePath))
            {
                MessageBox.Show("File path wrong format");
                return;
            }
            else
            {
                //acc cai gi do.................//
            }
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            FormMultiExport f = new FormMultiExport();
            f.MultiECNlist = txtECN.Text.Split(',').ToList();
            f.ShowDialog();
            
            // Access the public variable from FormA
            List<string> multiECN = f.MultiECNlist;
            if (multiECN != null && multiECN.Count > 0)
            {
                string data = string.Join(",", multiECN);
                txtECN.Text = data;
                PurchaseAction(data);
            }              
     
        }

        //private void FormMultiExport_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void txtECN_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtECN.Text))
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAction.RowCount > 0)
                {
                    List<Purchase_Action> dataList = new List<Purchase_Action>();

                    for (int row = 0; row < dgvAction.RowCount; row++)
                    {
                        Purchase_Action dataRow = new Purchase_Action();
                        dataRow.Action_Date = DateTime.Now;
                        dataRow.ECO_ControlSheet_Id = Common.ConvertINT(dgvAction.Rows[row].Cells["ECO Control Sheet ID"].Value);
                        dataRow.ReleaseDate = Common.ConvertDate(dgvAction.Rows[row].Cells["Ngày phát hành"].Value);
                        dataRow.ECN = Common.ConvertString(dgvAction.Rows[row].Cells["ECN"].Value);
                        dataRow.ECO_No = Common.ConvertString(dgvAction.Rows[row].Cells["ECO No"].Value);
                        dataRow.Old_Part_BOM1 = Common.ConvertString(dgvAction.Rows[row].Cells["Current part(BOM 1)"].Value);
                        dataRow.New_Part = Common.ConvertString(dgvAction.Rows[row].Cells["New part"].Value);
                        dataRow.Old_Price = Common.convertDouble(dgvAction.Rows[row].Cells["Current price"].Value);
                        dataRow.New_Price = Common.convertDouble(dgvAction.Rows[row].Cells["New price"].Value);
                        dataRow.Old_Vendor = Common.ConvertString(dgvAction.Rows[row].Cells["Current Vendor"].Value);
                        dataRow.New_Vendor = Common.ConvertString(dgvAction.Rows[row].Cells["New Vendor"].Value);
                        dataRow.Report = Common.ConvertString(dgvAction.Rows[row].Cells["Situation"].Value);
                        dataRow.Reason = Common.ConvertString(dgvAction.Rows[row].Cells["Reason"].Value);
                        dataRow.ETA_UMCVN = Common.ConvertString(dgvAction.Rows[row].Cells["ETA UMCVN"].Value);
                        dataRow.Est_Using_NewPart_Date = Common.ConvertString(dgvAction.Rows[row].Cells["Est using new part date"].Value);
                        dataRow.Transfered_ECO_Date = Common.ConvertString(dgvAction.Rows[row].Cells["Transfered ECO date"].Value);
                        dataRow.Purpose_Transfered_ECO = Common.ConvertString(dgvAction.Rows[row].Cells["Purpose transferred ECO date"].Value);
                        dataList.Add(dataRow);
                    }
                    if (_purchaseAction.InsertData(dataList))
                    {
                        MessageBox.Show("Save Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAction.RowCount > 0)
                {
                   // var pathBase = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseMaster);
                    var listData = GetDataFromDGV();
                    listData.Columns.RemoveAt(0); // xóa cột ID

                    // Display SaveFileDialog to save the Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save As Excel File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        ExcelServices.ExportData(listData, saveFileDialog.FileName);
                        MessageBox.Show("Data saved to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtECN.Text)) return;
            PurchaseAction(txtECN.Text);           
        }

        private void dgvAction_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingAction.Sort = dgvAction.SortString;
        }

        private void dgvAction_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingAction.Filter = dgvAction.FilterString;
        }

        private void btnReplaceSituation_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dgvAction.SelectedCells)
                {
                    if (cell.ColumnIndex >= dgvAction.Columns["Situation"].Index && cell.ColumnIndex <= dgvAction.Columns["Purpose transferred ECO date"].Index )
                    {
                        cell.Value = cbSituation.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\U42107\\Desktop\\ModelLocation";
            // Specify the file extension to search for
            string fileExtension = "*.xls";

            // Use Directory.GetFiles to get all files with the specified extension
            string[] xlsFiles = Directory.GetFiles(path, fileExtension);
            foreach (var item in xlsFiles)
            {
                _excelService.ImportLocationModel(item);
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cbModel.Text);
            cbModel.SelectedIndex = index;
            index++;
        }

        int index = 0;
        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            var modelList = _pI_BASE_Repository.GetModelList();
            cbModel.DataSource = modelList;            
        }

        private void dgvAction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the value of any cell in the current row has changed
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                MarkChangedRow(rowIndex,e.ColumnIndex);
            }
        }

        private void MarkChangedRow(int rowIndex,int cell)
        {
            // Change the background color of the entire row
            dgvAction.Rows[rowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
            dgvAction.Rows[rowIndex].Cells[cell].Style.BackColor = Color.GreenYellow;
        }
        private void ResetRowColors()
        {
            foreach (DataGridViewRow row in dgvAction.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Empty; // Reset to default color
            }
        }
    }
}
