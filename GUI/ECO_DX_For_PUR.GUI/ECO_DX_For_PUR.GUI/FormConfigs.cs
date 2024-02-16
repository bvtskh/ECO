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
    public partial class FormConfigs : Form
    {
        ExcelServices _excelService = new ExcelServices();
        public FormConfigs()
        {
            InitializeComponent();
        }

        private void FormConfigs_Load(object sender, EventArgs e)
        {
            try
            {
                txtECOControlSheetCanon.Text = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECOcontrolSheet);
                txtECNCanonPurchase.Text = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseAction);
                txtMaster.Text = NodeXml.GetFilePathFromXml(NodeXml.nodeXmlECNCanonPurchaseMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }

        private void btnOpenECOControlSheetCanon_Click(object sender, EventArgs e)
        {
            try
            {
                var path = _excelService.GetExelFilePath();
                txtECOControlSheetCanon.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }

        private void btnOpenECNCanonPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                var path = _excelService.GetExelFilePath();
                txtECNCanonPurchase.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }

        private void btnOpenMaster_Click(object sender, EventArgs e)
        {
            try
            {
                var path = _excelService.GetExelFilePath();
                txtMaster.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {              
                if(!NodeXml.UpdateFilePathToXml(txtECOControlSheetCanon.Text, NodeXml.nodeXmlECOcontrolSheet))
                {
                    MessageBox.Show($"File path: {txtECOControlSheetCanon.Text} invalid");
                    return;
                }
                else if(!NodeXml.UpdateFilePathToXml(txtECNCanonPurchase.Text, NodeXml.nodeXmlECNCanonPurchaseAction))
                {
                    MessageBox.Show($"File path: {txtECNCanonPurchase.Text} invalid");
                    return;
                }
                else if(!NodeXml.UpdateFilePathToXml(txtMaster.Text, NodeXml.nodeXmlECNCanonPurchaseMaster))
                {
                    MessageBox.Show($"File path: {txtMaster.Text} invalid");
                    return;
                }
                else
                {
                    MessageBox.Show("Save Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error: " + ex.Message);
            }
        }
    }
}
