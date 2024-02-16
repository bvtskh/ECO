using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
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
    public partial class FormRuningChange : Form
    {
        PurchaseAction_Repository _purchaseAction = new PurchaseAction_Repository();
        public FormRuningChange()
        {
            InitializeComponent();
        }

        private void FormRuningChange_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var dataPartList = _purchaseAction.GetPartRuningChange().Where(w=>w.Contains(txtmodel.Text)).ToList();
                List<object> list = new List<object>();
                foreach (var item in dataPartList)
                {
                    object data = new { PartName = item };
                    list.Add(data);
                }
                dataGridView1.DataSource = list;

                if (list.Count > 0)
                {
                    dataGridView1.Columns[0].HeaderText = "Part runing change";
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }              
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
