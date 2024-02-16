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
    public partial class FormMultiExport : Form
    {
        public List<string> MultiECNlist { get; internal set; }
        private bool closeCustom =false;
        public FormMultiExport()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                // Split the lines in the RichTextBox and save them to a List<string>
                List<string> stringList = new List<string>();
                foreach (string line in richTextBox1.Lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        stringList.Add(line.Trim());
                    }
                }
                MultiECNlist = stringList;
                closeCustom = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void FormMultiExport_Load(object sender, EventArgs e)
        {
            richTextBox1.Lines = MultiECNlist.ToArray();
        }

        private void FormMultiExport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeCustom == false)
            {
                MultiECNlist = null;
            }
        }
    }
}
