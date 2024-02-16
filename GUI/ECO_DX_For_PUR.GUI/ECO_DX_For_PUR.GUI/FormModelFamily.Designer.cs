
namespace ECO_DX_For_PUR.GUI
{
    partial class FormModelFamily
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dgvFamilyModel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.txtmodel = new Sunny.UI.UITextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyModel)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(495, 5);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 30);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "Fisrt Upload";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dgvFamilyModel
            // 
            this.dgvFamilyModel.AllowUserToAddRows = false;
            this.dgvFamilyModel.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamilyModel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamilyModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamilyModel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFamilyModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamilyModel.EnableHeadersVisualStyles = false;
            this.dgvFamilyModel.Location = new System.Drawing.Point(0, 0);
            this.dgvFamilyModel.Name = "dgvFamilyModel";
            this.dgvFamilyModel.RowHeadersVisible = false;
            this.dgvFamilyModel.Size = new System.Drawing.Size(595, 487);
            this.dgvFamilyModel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtmodel);
            this.panel1.Controls.Add(this.uiButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 39);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(383, 5);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmodel.Location = new System.Drawing.Point(4, 5);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmodel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Padding = new System.Windows.Forms.Padding(5);
            this.txtmodel.ShowText = false;
            this.txtmodel.Size = new System.Drawing.Size(372, 29);
            this.txtmodel.TabIndex = 2;
            this.txtmodel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtmodel.Watermark = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvFamilyModel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 487);
            this.panel2.TabIndex = 3;
            // 
            // FormModelFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormModelFamily";
            this.Text = "FormModelFamily";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilyModel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.DataGridView dgvFamilyModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UITextBox txtmodel;
    }
}