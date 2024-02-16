using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository;
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
    public partial class FormPrice : Form
    {
        IPRICE _price_Helper = new PRICE_Helper();
        ExcelServices _excelServices = new ExcelServices();
        DataTable dataSource;
        public FormPrice()
        {
            InitializeComponent();           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            try
            {
                Common.StartFormLoading();
                lbLastUpdate.Text = "Last update: "+ _price_Helper.GetLastUpdateTime();
                string partNo = txtPart.Text;
                dataSource = _price_Helper.GetDataByPartNo(partNo, intBox.Value);
                this.bindingSource1.DataSource = dataSource;
                dgvPrice.DataSource = this.bindingSource1.DataSource;
                foreach(DataGridViewColumn col in dgvPrice.Columns)
                {
                    col.Width = 135;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Common.CloseFormLoading();
            }
        }
        private void dgvPrice_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Sort = this.dgvPrice.SortString;
        }

        private void dgvPrice_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Filter = this.dgvPrice.FilterString;
        }

        private void txtPart_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }

        private void FormPrice_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = _excelServices.GetExelFilePath();
                _excelServices.ImportZMM70(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
