using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Bussiness.SQLHelper;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECO_DX_For_PUR.GUI
{
    public partial class FormVersion : Form
    {
        ILOGIN _versonHelper = new LoginHelper();
        public FormVersion()
        {
            InitializeComponent();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {
            txtcurrentVer.Text = _versonHelper.GetCurrentVersion();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CopyFilesAndFoldersToMyFolder();
        }
        private void CopyFilesAndFoldersToMyFolder()
        {
            if(System.Windows.Forms.Application.CompanyName != "C862")
            {
                MessageBox.Show("Liên hệ máy C862-DX để cập nhật!");
                return;
            }
            try
            {
                string sourceDirectory = @"C:\Users\U42107\Desktop\ThanhDX\Thanh_Project\ECO DX for PUR\ECO DX for PUR\GUI\ECO_DX_For_PUR.GUI\ECO_DX_For_PUR.GUI\bin\Debug"; // Change this to your project's Debug directory
                string savePath = @"\\172.28.10.12\DX Center\7.ECN_Management\StartUp\Version";
                string targetDirectory = Path.Combine(savePath, txtNextVer.Text);
                try
                {
                    // Check if the folder doesn't exist, then create it
                    if (!Directory.Exists(targetDirectory))
                    {
                        Directory.CreateDirectory(targetDirectory);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating folder: {ex.Message}");
                }             
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Version"].Value = txtNextVer.Text.Trim();
                config.Save(ConfigurationSaveMode.Modified);
                Versions version = new Versions();
                version.CREATE_DATE = DateTime.Now;
                version.VERSION1 = txtNextVer.Text.Trim();
                version.REMARK = txtRemark.Text;
                _versonHelper.SaveNewVersion(version);
                // Copy files and folders recursively
                CopyFilesRecursively(sourceDirectory, targetDirectory);
                MessageBox.Show("Update Success full!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying files and folders: " + ex.Message);
            }
        }

        private void CopyFilesRecursively(string sourceDirectory, string targetDirectory)
        {
            // Copy files
            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDirectory, fileName);
                File.Copy(file, destFile, true);
            }
        }
    }
}
