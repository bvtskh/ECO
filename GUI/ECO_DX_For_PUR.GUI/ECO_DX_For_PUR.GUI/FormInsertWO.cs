using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.ECO_CANON;
using ECO_DX_For_PUR.DATA.ECO_CANON.Repository;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.Utils;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormInsertWO : UIForm
    {
        ExcelServices _excelServices = new ExcelServices();
        //WO_Relationship_Repository _wO_Relationship_Repository = new WO_Relationship_Repository();
        IWO _woHelper = new WOHelper();
        object woPending;
        public FormInsertWO(object woPending)
        {
            InitializeComponent();
            panelImport.Controls.OfType<Sunny.UI.UIDatetimePicker>().ToList().ForEach(f => f.Value = DateTime.Now);
            this.woPending = woPending;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
                //try
                //{
                //    Common.StartFormLoading();
                //    var filePath = _excelServices.GetExelFilePath();
                //    if (filePath != null)
                //    {
                //        var dataTable = _excelServices.ImportExcel(filePath);
                //        List<Tbl_WO_Relationship> WOList = new List<Tbl_WO_Relationship>();
                //        foreach (DataRow row in dataTable.Rows)
                //        {
                //            var AIQty = Common.ConvertINT(row.Field<object>("AI- Qty"));
                //            var SMTQty = Common.ConvertINT(row.Field<string>("SMT Qty"));
                //            var SMTAQty = Common.ConvertINT(row.Field<string>("SMTA Qty"));
                //            var SMTBQty = Common.ConvertINT(row.Field<string>("SMTB Qty"));
                //            var FAT1Qty = Common.ConvertINT(row.Field<string>("FAT1 Qty"));
                //            var FAT2Qty = Common.ConvertINT(row.Field<string>("FAT2 Qty"));
                //            var FAT3Qty = Common.ConvertINT(row.Field<string>("FAT3 Qty"));
                //            //if (AIQty == null || SMTAQty == null || SMTBQty == null || FAT1Qty == null || FAT2Qty == null)
                //            //{
                //            //    MessageBox.Show($"Qty incorrect format");
                //            //    return;
                //            //}
                //            Tbl_WO_Relationship tbl_WO_Relationship = new Tbl_WO_Relationship();
                //            tbl_WO_Relationship.Customer = row.Field<string>("Customer");
                //            tbl_WO_Relationship.Model = row.Field<string>("Model");

                //            tbl_WO_Relationship.AI = row.Field<string>("AI- WO");
                //            tbl_WO_Relationship.AI_Qty = AIQty;
                //            tbl_WO_Relationship.AI_Date_Pro = Common.ConvertDate(row.Field<object>("AI- Date Pro"));

                //            tbl_WO_Relationship.SMT = row.Field<string>("SMT-WO");
                //            tbl_WO_Relationship.SMT_Qty = SMTQty;
                //            tbl_WO_Relationship.SMT_Date_Pro = Common.ConvertDate(row.Field<object>("SMT-Date pro"));

                //            tbl_WO_Relationship.SMTA = row.Field<string>("SMTA-WO");
                //            tbl_WO_Relationship.SMTA_Qty = SMTAQty;
                //            tbl_WO_Relationship.SMTA_Date_Pro = Common.ConvertDate(row.Field<object>("SMTA-Date pro"));

                //            tbl_WO_Relationship.SMTB = row.Field<string>("SMTB-WO");
                //            tbl_WO_Relationship.SMTB_Qty = SMTBQty;
                //            tbl_WO_Relationship.SMTB_Date_Pro = Common.ConvertDate(row.Field<object>("SMTB-Date pro"));

                //            tbl_WO_Relationship.FAT1 = row.Field<string>("FAT1-WO");
                //            tbl_WO_Relationship.FAT1_Qty = FAT1Qty;
                //            tbl_WO_Relationship.FAT1_Date_Pro = Common.ConvertDate(row.Field<object>("FAT1- Date pro"));

                //            tbl_WO_Relationship.FAT2 = row.Field<string>("FAT2-WO");
                //            tbl_WO_Relationship.FAT2_Qty = FAT2Qty;
                //            tbl_WO_Relationship.FAT2_Date_Pro = Common.ConvertDate(row.Field<object>("FAT2- Date pro"));

                //            tbl_WO_Relationship.FAT2 = row.Field<string>("FAT3-WO");
                //            tbl_WO_Relationship.FAT2_Qty = FAT3Qty;
                //            tbl_WO_Relationship.FAT2_Date_Pro = Common.ConvertDate(row.Field<object>("FAT3- Date pro"));

                //            tbl_WO_Relationship.UpdateTime = DateTime.Now;
                //            tbl_WO_Relationship.HostName = System.Windows.Forms.SystemInformation.ComputerName;
                //            WOList.Add(tbl_WO_Relationship);
                //        }
                //        if (_wO_Relationship_Repository.InsertData(WOList))
                //        {
                //            MessageBox.Show("Insert success full!");
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Common.CloseFormLoading();
                //    MessageBox.Show("Error: " + ex.Message);
                //}
                //finally
                //{
                //    Common.CloseFormLoading();
                //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string woPending = txtWOpending.Text;
                if (IsErrorWOPending(woPending)) return;

                var dataInsert = SetDataWORelationship(woPending);
                if(dataInsert!=null && dataInsert.Count > 0)
                {
                    if (_woHelper.InsertData(dataInsert))
                    {
                        MessageBox.Show("Insert Success full!");
                        FormWORelationship formWORelationship = (FormWORelationship)Common.FindForm("FormWORelationship");
                        if(formWORelationship != null)
                        {
                            formWORelationship.StartShowData();
                        }
                        this.Close();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsErrorWOPending(string woPending)
        {
            try
            {
                if (string.IsNullOrEmpty(woPending))
                {
                    ShowErrorTip("Nhập WO Pending trước khi thực hiện thao tác khác!", 1000);
                    return true;
                }
                if (!_woHelper.IsChangingWO(woPending))
                {
                    ShowErrorTip($"{woPending}: Không phải Pending WO!", 1000);
                    return true;
                }
                if (_woHelper.IsFinishWO(woPending))
                {
                    ShowErrorTip($"{woPending}: đã thêm trước đó rồi!", 1000);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private List<WO_Relationship> SetDataWORelationship(string woPending)
        {
            try
            {
                List<WO_Relationship> wO_RelationshipList = new List<WO_Relationship>();
                var textboxWOList = panelInsertWO.Controls.OfType<UITextBox>().ToList();
                if (AllTextboxValueIsNULL(textboxWOList))
                {
                    ShowErrorTip("Input WO!");
                    return null;
                }
                if (IsSimilarPendingWO(textboxWOList))
                {
                    ShowErrorTip("Phải điền 1 WO trùng với pending WO!");
                    return null;
                }
                var duplicateWO = IsDuplicateWO(textboxWOList);
                if (duplicateWO != null)
                {
                    ShowErrorTip("Không được trùng WO!");
                    foreach (var item in duplicateWO)
                    {
                        item.SelectAll();
                    }
                    return null;
                }
                if (!IsValidInput())
                {
                    ShowErrorTip("Phải điền ít nhất 1 WO SMT và FAT!");
                    return null;
                }
                var guid = Guid.NewGuid();
                foreach (UITextBox textBoxWO in textboxWOList)
                {
                    int index = int.Parse(textBoxWO.GetTag(2).ToString());
                    if (!IsAvalidWO(textBoxWO, index)) return null;
                    if (!string.IsNullOrEmpty(textBoxWO.Text))
                    {
                        UITextBox textboxQty = (UITextBox)textBoxWO.GetTag(0); // textbox qty
                        if (!IsQTYNOTAlvalid(textboxQty))
                        {
                            ShowErrorTip($"{textBoxWO.GetTag(1)} QTY is Invalid value!");
                            return null;
                        }

                        wO_RelationshipList.Add(SetUpWO(textBoxWO, textboxQty, index, guid));
                    }
                }
                return wO_RelationshipList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrEmpty(txtSMTA.Text) && string.IsNullOrEmpty(txtSMTB.Text) && string.IsNullOrEmpty(txtSMT.Text)) return false;
            if (string.IsNullOrEmpty(txtFAT1.Text) && string.IsNullOrEmpty(txtFAT2.Text) && string.IsNullOrEmpty(txtFAT3.Text)) return false;
            return true;
        }

        private List<UITextBox> IsDuplicateWO(List<UITextBox> textboxWOList)
        {
            List<string> txtValueList = new List<string>();
            foreach(var item in textboxWOList)
            {
                if (string.IsNullOrEmpty(item.Text)) continue;
                if (txtValueList.Contains(item.Text))
                {
                    return GetTextBoxWO(item.Text, textboxWOList);
                }
                txtValueList.Add(item.Text.Trim());
            }
            return null;
        }

        private List<UITextBox> GetTextBoxWO(string text, List<UITextBox> textboxWOList)
        {
            List<UITextBox> uITextBoxes = new List<UITextBox>();
            foreach(var textbox in textboxWOList)
            {
                if (textbox.Text.Trim() == text.Trim()) uITextBoxes.Add(textbox);
            }
            return uITextBoxes;
        }

        private bool IsSimilarPendingWO(List<UITextBox> textboxWOList)
        {
            foreach (var value in textboxWOList)
            {
                if (value.Text == txtWOpending.Text)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsQTYNOTAlvalid(UITextBox textboxQty)
        {
            int result;
            if (string.IsNullOrEmpty(textboxQty.Text)) return true;

            if (int.TryParse(textboxQty.Text, out result))
            {
                if (result <= 0) return false;
                return true;
            }         
            return false;
        }

        private WO_Relationship SetUpWO( UITextBox textBoxWO, UITextBox textboxQty, int index, Guid guid)
        {
            WO_Relationship wO_Relationship = new WO_Relationship();
            wO_Relationship.ORDER_NO = textBoxWO.Text;
            wO_Relationship.TYPE_ID = int.Parse(textBoxWO.GetTag(3).ToString());
            wO_Relationship.TYPE_NAME = textBoxWO.GetTag(4).ToString();
            wO_Relationship.ORDER_BASE = guid;
            wO_Relationship.QTY = GetQty(textboxQty);
            wO_Relationship.UPDATE_NAME = "";
            wO_Relationship.HOST_NAME = System.Windows.Forms.SystemInformation.ComputerName;
            wO_Relationship.UPDATE_TIME = DateTime.Now;
            // get rdo selected.
            var rdoSelected = GetChangeIdOfECO();
            wO_Relationship.CHANGE_ID = null;// Convert.ToInt16(rdoSelected.Name.Split('_').Last());
            wO_Relationship.CHANGE_NAME = null;// rdoSelected.Text;

            return wO_Relationship;
        }

        private int? GetQty(UITextBox textboxQty)
        {
            int result;
            if (string.IsNullOrEmpty(textboxQty.Text)) return null;
            if (int.TryParse(textboxQty.Text, out result))
            {
                if (result == 0) return null;
                return result;
            }
            return null;
        }

        private bool AllTextboxValueIsNULL(List<UITextBox> textboxWO)
        {
            foreach (var value in textboxWO)
            {
                if (!string.IsNullOrEmpty(value.Text))
                {
                    return false;
                }               
            }           
            return true;
        }

        private bool IsAvalidWO(UITextBox textBox, int index)
        {
            string value = textBox.Text;
            int result;
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Length != 10)
                {
                    ShowErrorTip($"{textBox.GetTag(1)}: wrong format!"); return false;
                }
                if (value.Substring(0, 4) != "2000")
                {
                    ShowErrorTip($"{textBox.GetTag(1)}: wrong format!"); return false;
                }
                if (int.TryParse(value.Substring(4, 6), out result) == false)
                {
                    ShowErrorTip($"{textBox.GetTag(1)}: wrong format!"); return false;
                }
                //if (_wO_Relationship_Repository.IsExistWO(textBox.Text, index))
                //{
                //    ShowErrorTip($"{textBox.GetTag(1)}: {textBox.Text} is Exist!"); return false;
                //}
            }
            return true;
        }

        private UIRadioButton GetChangeIdOfECO()
        {
            return panelImport.Controls.OfType<UIRadioButton>().Where(w=>w.Checked == true).FirstOrDefault();          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelImport.Controls.OfType<UITextBox>().ToList().ForEach(f => f.Clear());
        }
        private void activeChange(object sender, EventArgs e)
        {
            var control = sender as UISwitch;
            if (control != null && !control.Active)
                ShowErrorTip(control, "Empty Time!", 1000, true);
            else
                ShowSuccessTip(control, "Choose Time!", 1000, true);
        }

        private void FormInsertWO_Load(object sender, EventArgs e)
        {
            rdo_0.Checked = true;
            SetTagWOLabel();
            if (this.woPending != null)
            {
                txtWOpending.Text = this.woPending.ToString();
            }
        }

      
        private void SetTagWOLabel() //textboxqty, label, index, type,name,typeValid
        {
            txtAI.InitTag(txtAIQty, "AI WO",0,0,"AI");
            txtSMTA.InitTag(txtSMTAQty, "SMTA WO",1,1,"SMTA");
            txtSMTB.InitTag(txtSMTBQty, "SMTB WO",2,2,"SMTB");
            txtSMT.InitTag( txtSMTQty, "SMT WO",3,3,"SMT");
            txtFAT1.InitTag(txtFAT1Qty, "FAT1 WO",4,4,"FAT");
            txtFAT2.InitTag(txtFAT2Qty, "FAT2 WO",5,4,"FAT");
            txtFAT3.InitTag(txtFAT3Qty, "FAT3 WO",6,4,"FAT");
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, suppress the key press
                e.Handled = true;
            }
        }
    }
}
