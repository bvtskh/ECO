using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.Utils;
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
    public partial class FormSelectFinishECN : Form
    {
        PurchaseAction_Repository _purchaseAction = new PurchaseAction_Repository();

        DataTable dataFinish;
        public FormSelectFinishECN()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.Sort = null;
                this.bindingSource1.Filter = null;
                FormPurchase f = new FormPurchase();
                DataTable dataTable = Datatable_Common.CreateColumnFinishAction();
                string ecnSearch = txtECN.Text;
                if (!string.IsNullOrEmpty(ecnSearch))
                {
                    var data = _purchaseAction.GetECOListByECN(ecnSearch);
                    if (data.Count > 0)
                    {
                        dataFinish = f.ResultDataFinished(dataTable, data); ;
                        this.bindingSource1.DataSource = dataFinish;
                        advancedDataGridView1.DataSource = this.bindingSource1.DataSource;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" +ex.Message);
            }
            
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = this.advancedDataGridView1.FilterString;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (advancedDataGridView1.RowCount > 0)
                {
                    var pathBase = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseMaster);
                    var listData = GetDataFromDGV();

                    // Display SaveFileDialog to save the Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save As Excel File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        ExcelServices.ExportData(listData, pathBase, saveFileDialog.FileName);
                        MessageBox.Show("Data saved to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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

                foreach (DataGridViewColumn column in advancedDataGridView1.Columns)
                {
                    dataTable.Columns.Add(column.Name);
                }

                // Transfer data from DataGridView to DataTable
                foreach (DataGridViewRow row in advancedDataGridView1.Rows)
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
        
    }
}
