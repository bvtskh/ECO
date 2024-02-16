using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
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
    public partial class FormModelFamily : Form
    {
        ExcelServices _excelService = new ExcelServices();
        public FormModelFamily()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DBContext())
                {
                    string path = _excelService.GetExelFilePath();
                    var data = _excelService.ImportExcel(path);
                    List<string> list = new List<string>();
                    foreach (DataRow row in data.Rows)
                    {
                        list.Add(row.Field<string>(1));
                    }

                    List<Model_Family> listmodel = new List<Model_Family>();
                    foreach (DataRow row in data.Rows)
                    {
                        for (int col = 2; col < data.Columns.Count; col++)
                        {
                            if (!string.IsNullOrEmpty(row.Field<string>(col)))
                            {
                                Model_Family tbl_Model_Family = new Model_Family();
                                tbl_Model_Family.Model_Type = row.Field<string>(0);
                                tbl_Model_Family.Origin_Model = row.Field<string>(1)+"-000SS01";
                                tbl_Model_Family.Branch_Model = row.Field<string>(col)+"-000SS01";
                                var modelExist = ctx.Model_Family.Where(w => w.Branch_Model == tbl_Model_Family.Branch_Model && w.Model_Type == tbl_Model_Family.Model_Type && w.Origin_Model == tbl_Model_Family.Origin_Model).FirstOrDefault();
                                if (modelExist == null)
                                {
                                    listmodel.Add(tbl_Model_Family);
                                }
                            }
                        }
                    }
                     ctx.Model_Family.AddRange(listmodel);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DBContext())
                {
                    var modelFamilyList = ctx.Model_Family.Where(w=>w.Branch_Model.Contains(txtmodel.Text) || w.Origin_Model.Contains(txtmodel.Text)).ToList();
                    dgvFamilyModel.DataSource = modelFamilyList;
                    foreach (DataGridViewColumn column in dgvFamilyModel.Columns)
                    {
                        column.Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
