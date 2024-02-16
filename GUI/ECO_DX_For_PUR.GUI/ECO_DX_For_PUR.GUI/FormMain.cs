using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormMain : Form
    {
        ILOGIN _version = new LoginHelper();

        private Timer timerOut;
        private Timer timerCheckVersion;
        private int count = 60;
        private int refreshTimer = 300;
        private bool isOldversion = false;
        public FormMain()
        {
            InitializeComponent();
            //menuStrip1.BackColor = Color.Tan;
            menuStrip1.Items[0].BackColor = Color.FromArgb(46, 180, 182);
            InitializeTimerOut();
            InitializeTimerCheckVersion();
        }
        private void InitializeTimerOut()
        {
            timerOut = new Timer();
            timerOut.Interval = 1000; // 1 second
            timerOut.Tick += TimerOut_Tick;            
        }
        private void InitializeTimerCheckVersion()
        {
            timerCheckVersion = new Timer();
            timerCheckVersion.Interval = 1000; // 1 second
            timerCheckVersion.Tick += TimerCheckVersion_Tick;
        }

        private void TimerCheckVersion_Tick(object sender, EventArgs e)
        {
            refreshTimer--;
            if (refreshTimer == 0 && isOldversion)
            {
                timerCheckVersion.Stop();               
            }
            else
            {
                if (refreshTimer == 0 && !isOldversion)
                {
                    CheckVersion();
                    refreshTimer = 10;
                }
            }
        }

        private void TimerOut_Tick(object sender, EventArgs e)
        {
            count--;
            lbTimer.Text = "Time Out:" + count.ToString();
            if (count <=0)
                Application.Exit();
        }

        private void btnPurECN_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormPurchase openForm = (FormPurchase)Application.OpenForms["FormPurchase"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormPurchase());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            this.Text ="ECO/ECN Management "+ config.AppSettings.Settings["Version"].Value;
            timerCheckVersion.Start();
            btnPurECN.BackColor = Color.White;
            FormPurchase openForm = (FormPurchase)Application.OpenForms["FormPurchase"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormPurchase());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
            FirstCheckVersion();
        }

        private void FirstCheckVersion()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string current = config.AppSettings.Settings["Version"].Value;
            if (_version.IsOldVersion(current))
            {
                MessageBox.Show(@"Đã cập nhật phiên bản mới nhất, vui lòng truy cập đường dẫn: \\vn - file\DX Center\7.ECN_Management\StartUp để sử dụng phiên bản mới nhất!", "Thông báo cập nhật phiên bản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
        private void CheckVersion()
        {
            if (isOldversion) timerCheckVersion.Stop();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string current = config.AppSettings.Settings["Version"].Value;
            if (_version.IsOldVersion(current))
            {
                isOldversion = true;
                timerCheckVersion.Stop();
                MessageBox.Show(@"Đã cập nhật phiên bản mới nhất, vui lòng truy cập đường dẫn: \\vn - file\DX Center\7.ECN_Management\StartUp để sử dụng phiên bản mới nhất!","Thông báo cập nhật phiên bản",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Chương trình sẽ tự tắt sau 1 phút!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerOut.Start();              
            }
        }

        private void btnPEDM_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormPEDM openForm = (FormPEDM)Application.OpenForms["FormPEDM"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormPEDM());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormPrice openForm = (FormPrice)Application.OpenForms["FormPrice"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormPrice());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void btnConfigs_Click(object sender, EventArgs e)
        {           
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormWORelationship openForm = (FormWORelationship)Application.OpenForms["FormWORelationship"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormWORelationship());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void configsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConfigs f = new FormConfigs();
            f.ShowDialog();
        }

        private void modelFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModelFamily f = new FormModelFamily();
            f.Show();
        }

        private void runingChangePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRuningChange f = new FormRuningChange();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCheckModel f = new FormCheckModel();
            f.Show();
        }


        private void btnECOApprove_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            string dllPath = @"\\172.28.10.12\DX Center\999.Lib\ECO.dll";

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"DLL")))
            //{
            //    Directory.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DLL"),true);
            //}
            string folderPath = Path.Combine(desktopPath, "DLL");
            try
            {
                // Check if the folder doesn't exist, then create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating folder: {ex.Message}");
            }

            string destinationPath = Path.Combine(folderPath, "ECO.dll");
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download the DLL file
                    client.DownloadFile(dllPath, destinationPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading DLL file: {ex.Message}");
            }
            try
            {
                // Load the DLL
                Assembly assembly = Assembly.LoadFile(destinationPath);

                // Specify the full name of the form class (including namespace)
                var formTypeName = assembly.GetType("ECO.Login");

                // Create an instance of the form
                Form form = (Form)Activator.CreateInstance(formTypeName,new object[] {""});

                if (form != null)
                {
                    if (!Common.IsExitsForm(form.Name))
                    {
                        form.Show();
                    }
                    form.TopMost = true;
                    form.BringToFront();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to create an instance of the specified form: {ex.Message}");
            }         
        }

        private void viewPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormViewPDF f = new FormViewPDF();
            //f.Show();
        }

        private void btnWOPlan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormWOPlan openForm = (FormWOPlan)Application.OpenForms["FormWOPlan"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormWOPlan());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void btnECOSchedule_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Common.ClickButtonMenu(btn, panelButton);
            FormECOSchedule openForm = (FormECOSchedule)Application.OpenForms["FormECOSchedule"];
            if (openForm == null)
            {
                this.panelPasteForm.TabPages.Add((Form)new FormECOSchedule());
            }
            else
            {
                this.panelPasteForm.TabPages[(Form)openForm].Select();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVersion f = new FormVersion();
            f.Show();
        }
    }
}
