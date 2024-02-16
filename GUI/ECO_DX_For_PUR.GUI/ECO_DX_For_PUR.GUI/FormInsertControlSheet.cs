using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
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
    public partial class FormInsertControlSheet : Form
    {
        PE_DM_ControlSheet_Repository _repository = new PE_DM_ControlSheet_Repository();
        public FormInsertControlSheet()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsExistedECN(txtECN.Text))
                {
                    MessageBox.Show($"ECN: {txtECN.Text} is existed, can be not Insert!");
                    return;
                }
                var textboxList = panelScroll.Controls.OfType<TextBox>().ToList();
                if (textboxList.Where(w => !string.IsNullOrWhiteSpace(w.Text)).Count() > 0)
                {
                    if (IsNullOrEmpty(txtECN.Text, txtECO.Text))
                    {
                        MessageBox.Show("ECN and ECO cannot be empty!"); return;
                    }

                    ECO_ControlSheet ecoControlSheet = CreateNewECOcontrolSheet();
                    if (_repository.InsertData(ecoControlSheet))
                    {
                        MessageBox.Show("Insert Success full");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("All value cannot be empty");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }            
        }

        private bool IsExistedECN(string ecn)
        {
            try
            {
                return _repository.IsExistedECN(ecn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }

        private bool IsNullOrEmpty(params string[] textboxList)
        {
            foreach (var txt in textboxList)
            {
                if (string.IsNullOrWhiteSpace(txt)) return true;
            }
            return false;
        }
        private ECO_ControlSheet CreateNewECOcontrolSheet()
        {
            try
            {
                return new ECO_ControlSheet
                {
                    No = int.Parse(txtNo.Text),
                    ECN_ReceiveDate = dtpECNReceice.Value.Date,
                    ECN_ERI_No = txtECN.Text,
                    History = txtHistory.Text,
                    Ver_EE = txtVerEE.Text,
                    Ver_EA = txtVerEA.Text,
                    Apply = txtApply.Text,
                    VE_Follows_ECN_CVN = txtVEFollow.Text,
                    ECO_No = txtECO.Text,
                    ModelName = txtModelName.Text,
                    OldPartCode = txtOldPart.Text,
                    NewPartCode = txtNewPart.Text,
                    Location = txtLocation.Text,
                    ContentOfChange = txtContentChange.Text,
                    ProcessForAssembly = txtProcess.Text,
                    ECO_Issue = txtECOIssue.Text,
                    FAT_Implement = txtFATImplement.Text,
                    ImplementDate = txtImplementDate.Text,
                    ShippingDate = txtShippingDate.Text,
                    ECO_Status = txtECOStatus.Text,
                    Confirm = txtConfirm.Text,
                    Issue_To = txtIssueTo.Text,
                    FATContentInformation = txtFATContent.Text,
                    ModelFull = txtModelFullName.Text,
                    TVP_No = txtTVP.Text,
                    TVPResult = txtTVPresult.Text,
                    TVP_RecieveResultDate = txtTVPreceiveResultDate.Text,
                    BOM_Change_When_ECO_Implement = txtBOMchange.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panelScroll.Top = -vScrollBar1.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelScroll.Controls.OfType<TextBox>().ToList().ForEach(f => f.Text = "");
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void FormInsertControlSheet_Load(object sender, EventArgs e)
        {
            txtNo.Tag = lbNo;
            txtECN.Tag = lbECN;
            //
            dtpECNReceice.Tag = lbReceiveDate;
            txtHistory.Tag = lbHistory;
            txtVerEE.Tag = lbEE;
            txtVerEA.Tag = lbEA;
            txtApply.Tag = lbApply;
            txtVEFollow.Tag = lbVEFollowECN;
            txtECO.Tag = lbECO;
            txtModelName.Tag = lbModelName;
            txtOldPart.Tag = lbOldPart;
            txtNewPart.Tag = lbNewPart;
            txtContentChange.Tag = lbContentchange;
            txtLocation.Tag = lbLocation;
            txtProcess.Tag = lbProcess;
            txtECOIssue.Tag = lbECOissue;
            txtImplementDate.Tag = lbImplementDate;
            txtFATImplement.Tag = lbFATaction;
            txtShippingDate.Tag = lbShippingDate;
            txtECOStatus.Tag = lbECOstatus;
            txtConfirm.Tag = lbConfirm;
            txtIssueTo.Tag = lbIssueTo;
            txtFATContent.Tag = lbFATcontent;
            txtModelFullName.Tag = lbModelFull;
            txtTVP.Tag = lbTVPNO;
            txtTVPresult.Tag = lbTVPResult;
            txtTVPreceiveResultDate.Tag = lbReceiveTVPresultdDate;
            txtBOMchange.Tag = lbChangeBOM;
        }
        private void textbox_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    var labelTag = (Sunny.UI.UIMarkLabel)textBox.Tag;
                    labelTag.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " +ex.Message);
            }

        }
        private void textbox_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    var labelTag = (Sunny.UI.UIMarkLabel)textBox.Tag;
                    labelTag.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void dtpECNReceice_MouseDown(object sender, MouseEventArgs e)
        {
            lbReceiveDate.ForeColor = Color.Red;
        }

        private void dtpECNReceice_MouseLeave(object sender, EventArgs e)
        {
            lbReceiveDate.ForeColor = Color.Black;
        }
    }
}
