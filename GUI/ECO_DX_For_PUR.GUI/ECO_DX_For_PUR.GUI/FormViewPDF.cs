//using PI_Lib;
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
    public partial class FormViewPDF : Form
    {
        private string urlPDF;
        private string usr;
        USAPService.USAPWebServiceSoapClient _usap = new USAPService.USAPWebServiceSoapClient();
        public FormViewPDF(string urlPDF,string usr)
        {
            InitializeComponent();
            this.urlPDF = urlPDF;
            this.usr = usr;
        }

        private void FormViewPDF_Load(object sender, EventArgs e)
        {
            // Assuming you have a link to the PDF file
            //string pdfLink = "http://172.28.10.9/UMCDC/202209/20220927104742320.pdf";          
            // var a = PI_Lib.MankichiHelper.GetByStaffCode("42107");
            // Navigate to the PDF file using the WebBrowser control
            if (!string.IsNullOrEmpty(this.urlPDF))
            {
                webBrowser1.Navigate(this.urlPDF);
            }
            txtECO.Text = usr;
        }

        private void txtECN_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtECO.Text))
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtECO.Text))
                {
                    var pdflink = _usap.GetFullPathDocument(txtECO.Text);
                    if (!string.IsNullOrEmpty(pdflink))
                    {
                        webBrowser1.Navigate(pdflink);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"PDF not found for USR: {txtECO.Text}");
            }
        }
    }
}
