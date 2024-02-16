using ECO_DX_For_PUR.DATA.Bussiness.EnumDefine;
using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using ECO_DX_For_PUR.Utils;
using Sunny.UI;
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
    public partial class FormInsertECOSchedule : UIForm
    {
        ExcelServices _excelServices = new ExcelServices();
        IECO_SCHEDULE _ecoSchedule = new ECO_Schedule_Helper();

        ECO_Edit edit;
        ECOSchedule ecoSchedule;
        public FormInsertECOSchedule(ECO_Edit _Edit, ECOSchedule ecoSchedule)
        {
            InitializeComponent();
            receiveDate.Value = DateTime.Now;
            startApproveDate.Value = DateTime.Now;
            implement_date.Value = DateTime.Now;
            this.edit = _Edit;
            this.ecoSchedule = ecoSchedule;
        }

        private void FormInsertECOSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.edit == ECO_Edit.Insert)
                {
                    lblTitle.Text = "Nhập dữ liệu";
                    //txtECO.Enabled = false;
                }
                else if (this.edit == ECO_Edit.Update)
                {
                    lblTitle.Text = "Cập nhật dữ liệu";
                    if (this.ecoSchedule != null)
                    {
                        receiveDate.Value = SetValueDate(this.ecoSchedule.RECEIVE_DOCUMENT_DATE);
                        startApproveDate.Value = SetValueDate(this.ecoSchedule.START_APPROVE_DATE);
                        implement_date.Value = SetValueDate(this.ecoSchedule.IMPLEMENT_DATE);
                        txtContentChange.Text = this.ecoSchedule.CONTENT_CHANGE;
                        txtECN.Text = this.ecoSchedule.ECN_DCI_NO;
                        txtECO.Text = this.ecoSchedule.ECO_NO;
                        txtModel.Text = this.ecoSchedule.MODEL;
                        txtRemark.Text = this.ecoSchedule.REMARK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DateTime SetValueDate(DateTime? date)
        {
            if (date != null) return (DateTime)date;
            return DateTime.Now;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                ShowInfoTip("Hãy điền thông tin!");
                return;
            }
            try
            {
                if (this.edit == ECO_Edit.Insert)
                {

                    var ecoSchedule = GetECOSchedule();
                    if (_ecoSchedule.IsExistECOData(ecoSchedule))
                    {
                        ShowErrorTip("Đã tồn tại dữ liệu này!"); return;
                    }
                    if (ecoSchedule != null)
                    {
                        if (_ecoSchedule.InsertEcoSchedule(ecoSchedule))
                        {
                            ShowSuccessTip("Success full!");
                            FormECOSchedule formECOSchedule = (FormECOSchedule)Common.FindForm("FormECOSchedule");
                            formECOSchedule.ShowECOScheduleData();
                        }
                    }
                }
                else if (this.edit == ECO_Edit.Update)
                {
                    var dataUpdate = GetECOSchedule();
                    var existData = _ecoSchedule.GetExistECOData(this.ecoSchedule);
                    int id = existData.ID;

                    if (_ecoSchedule.UpdateECOSchedule(dataUpdate, id))
                    {
                        ShowSuccessTip("Update Success full!");
                        FormECOSchedule formECOSchedule = (FormECOSchedule)Common.FindForm("FormECOSchedule");
                        formECOSchedule.ShowECOScheduleData();
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private ECOSchedule GetECOSchedule()
        {
            try
            {
                ECOSchedule eCOSchedule = new ECOSchedule();
                if (switchReceiveDate.Active)
                {
                    eCOSchedule.RECEIVE_DOCUMENT_DATE = receiveDate.Value.Date;
                }
                if (switchStartApproveDate.Active)
                {
                    eCOSchedule.START_APPROVE_DATE = startApproveDate.Value.Date;
                }
                if (switchImplementDate.Active)
                {
                    eCOSchedule.IMPLEMENT_DATE = implement_date.Value.Date;
                }
                eCOSchedule.MODEL = txtModel.Text.ToUpper();
                eCOSchedule.CONTENT_CHANGE = txtContentChange.Text;
                eCOSchedule.ECN_DCI_NO = txtECN.Text.ToUpper();
                eCOSchedule.ECO_NO = txtECO.Text.ToUpper();
                eCOSchedule.REMARK = txtRemark.Text;
                return eCOSchedule;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        private bool IsEmpty()
        {
            var textBoxList = panelInsert.Controls.OfType<UITextBox>().ToList();
            foreach (var item in textBoxList)
            {
                if (!string.IsNullOrEmpty(item.Text)) return false;
            }
            return true;
        }

        private void uiSwitch_ValueChanged(object sender, bool value)
        {
            var switchChange = sender as UISwitch;
            if (!switchChange.Active)
            {
                ShowInfoTip(switchChange, "Bỏ trống thời gian");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = _excelServices.GetExelFilePath();
                if (!string.IsNullOrEmpty(filepath))
                {
                    Common.StartFormLoading();
                    var dataImport = _excelServices.GetdataECOSchedule(filepath);
                    if (dataImport != null)
                    {
                        if (_ecoSchedule.InsertAndUpdateEcoSchedule(dataImport))
                        {
                            ShowSuccessTip("Success full!");
                            FormECOSchedule formECOSchedule = (FormECOSchedule)Common.FindForm("FormECOSchedule");
                            MethodInfo methodInfo = typeof(FormECOSchedule).GetMethod("ShowECOScheduleData");
                            methodInfo.Invoke(formECOSchedule, null);
                        }
                        Common.CloseFormLoading();
                    }
                }
            }
            catch (Exception ex)
            {
                Common.CloseFormLoading();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
