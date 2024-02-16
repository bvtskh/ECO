using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
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
    public partial class FormCheckModel : Form
    {
        ECO_ControlSheet_Repository _repositoryECOControlSheet = new ECO_ControlSheet_Repository();
        private List<string> listRepository;


        public FormCheckModel()
        {
            InitializeComponent();
        }

        private void FormCheckModel_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Common.StartFormLoading();
                if(listRepository == null)
                {
                    listRepository = _repositoryECOControlSheet.GetModelNameNOTBOM();
                }

                List<object> data = new List<object>();
                foreach (var item in listRepository)
                {
                    if (item.Contains(txtmodel.Text))
                    {
                        data.Add(new { Modelname = item });
                    }
                }
                 dataGridView1.DataSource = data;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }                                                   
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Thread.Sleep(200);
                Common.CloseFormLoading();
            }
        }
    }
}
