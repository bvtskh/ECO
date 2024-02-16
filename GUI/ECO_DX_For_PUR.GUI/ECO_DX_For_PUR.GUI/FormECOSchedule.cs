using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ECO_DX_For_PUR.DATA.Bussiness.EnumDefine.ECO_Schedule_Enum;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormECOSchedule : Form
    {
        DataTable _datatable;
        IECO_SCHEDULE _Schedule_Helper = new ECO_Schedule_Helper();
        public FormECOSchedule()
        {
            InitializeComponent();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormInsertECOSchedule f = new FormInsertECOSchedule(ECO_Edit.Insert, null); ;
            f.Show();
        }

        private void FormECOSchedule_Load(object sender, EventArgs e)
        {
            dateFrom.Value = DateTime.Now.AddDays(-150);
            dateTo.Value = DateTime.Now;
        }

        private DataTable ToDatatable(List<ECOSchedule> eCOSchedules)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Ngày nhận tài liệu");
                dataTable.Columns.Add("Ngày triển khai");
                dataTable.Columns.Add("Model");
                dataTable.Columns.Add("Nội dung thay đổi");
                dataTable.Columns.Add("ECN, DCI No.");
                dataTable.Columns.Add("Ngày bắt đầu áp dụng");
                dataTable.Columns.Add("UMC ECO No.");
                dataTable.Columns.Add("REMARK");
                foreach (var item in eCOSchedules)
                {
                    var row = dataTable.NewRow();
                    row["Ngày nhận tài liệu"] = Common.ConvertDate(item.RECEIVE_DOCUMENT_DATE);
                    row["Ngày triển khai"] = Common.ConvertDate(item.IMPLEMENT_DATE);
                    row["Model"] = item.MODEL;
                    row["Nội dung thay đổi"] = item.CONTENT_CHANGE;
                    row["ECN, DCI No."] = item.ECN_DCI_NO;
                    row["Ngày bắt đầu áp dụng"] = Common.ConvertDate(item.START_APPROVE_DATE);
                    row["UMC ECO No."] = item.ECO_NO;
                    row["REMARK"] = item.REMARK;
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

        public void ShowECOScheduleData()
        {
            this.bindingSource1.Sort = null;
            this.bindingSource1.Filter = null;
            try
            {
                Common.StartFormLoading();
                if (checkboxPending.Checked)
                {
                    _datatable = ToDatatable(_Schedule_Helper.GetAllDataECOSchedule().OrderByDescending(o => o.ID).Where(w => string.IsNullOrEmpty(w.ECO_NO)).ToList());
                    this.bindingSource1.DataSource = _datatable;
                    dgvECO_Schedule.DataSource = this.bindingSource1;
                }
                else
                {
                    _datatable = ToDatatable(_Schedule_Helper.GetAllDataECOSchedule().Where(w => w.RECEIVE_DOCUMENT_DATE >= dateFrom.Value && w.RECEIVE_DOCUMENT_DATE <= dateTo.Value).ToList());
                    this.bindingSource1.DataSource = _datatable;
                    dgvECO_Schedule.DataSource = this.bindingSource1;
                }
                lblStatus.Text = _datatable.Rows.Count + " Rows";
                dgvECO_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvECO_Schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvECO_Schedule.Columns["Nội dung thay đổi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Common.CloseFormLoading();
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        DataGridViewRow selectRow;
        private void dgvECO_Schedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectRow = dgvECO_Schedule.Rows[e.RowIndex];
            }
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectRow != null && selectRow.Index != -1)
                {
                    ECOSchedule eCOSchedule = new ECOSchedule();
                    eCOSchedule.RECEIVE_DOCUMENT_DATE = Common.ConvertDate(selectRow.Cells["Ngày nhận tài liệu"].Value);
                    eCOSchedule.IMPLEMENT_DATE = Common.ConvertDate(selectRow.Cells["Ngày triển khai"].Value);
                    eCOSchedule.START_APPROVE_DATE = Common.ConvertDate(selectRow.Cells["Ngày bắt đầu áp dụng"].Value);
                    eCOSchedule.CONTENT_CHANGE = Common.ConvertString(selectRow.Cells["Nội dung thay đổi"].Value);
                    eCOSchedule.MODEL = Common.ConvertString(selectRow.Cells["Model"].Value);
                    eCOSchedule.ECN_DCI_NO = Common.ConvertString(selectRow.Cells["ECN, DCI No."].Value);
                    eCOSchedule.ECO_NO = Common.ConvertString(selectRow.Cells["UMC ECO No."].Value);
                    FormInsertECOSchedule f = new FormInsertECOSchedule(ECO_Edit.Update, eCOSchedule);
                    f.Show();
                }
                else
                {
                    FormInsertECOSchedule f = new FormInsertECOSchedule(ECO_Edit.Insert, null);
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dgvECO_Schedule_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Sort = this.dgvECO_Schedule.SortString;
        }

        private void dgvECO_Schedule_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = this.dgvECO_Schedule.FilterString;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvECO_Schedule.RowCount > 0)
                //{
                    // var pathBase = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseMaster);
                    var listData = GetDataFromDGV();

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
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private DataTable GetDataFromDGV()
        {
            try
            {
                // Create a DataTable with the same columns as in the DataGridView
                var dataTable = new DataTable();

                foreach (DataGridViewColumn column in dgvECO_Schedule.Columns)
                {
                    dataTable.Columns.Add(column.Name);
                }

                // Transfer data from DataGridView to DataTable
                foreach (DataGridViewRow row in dgvECO_Schedule.Rows)
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

        private void checkboxPending_CheckedChanged(object sender, EventArgs e)
        {
            ShowECOScheduleData();
        }

        private void date_ValueChanged(object sender, DateTime value)
        {
            ShowECOScheduleData();
        }
    }
}
