
namespace ECO_DX_For_PUR.GUI
{
    partial class FormPEDM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPEDM));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPEDM = new ADGV.AdvancedDataGridView();
            this.contextSelectRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelShowFormAdd = new System.Windows.Forms.Panel();
            this.panelAdvanced = new Sunny.UI.UIPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTo = new Sunny.UI.UIDatePicker();
            this.dateFrom = new Sunny.UI.UIDatePicker();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.cbIssue = new Sunny.UI.UIComboBox();
            this.intBox = new Sunny.UI.UIIntegerUpDown();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnCheckUpdate = new Sunny.UI.UISymbolButton();
            this.btnAdvanced = new Sunny.UI.UIMarkLabel();
            this.cbSelectTypeSearch = new Sunny.UI.UIComboBox();
            this.txtSearchContent = new Sunny.UI.UITextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSourceECO = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEDM)).BeginInit();
            this.contextSelectRow.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceECO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPEDM);
            this.panel2.Controls.Add(this.panelShowFormAdd);
            this.panel2.Controls.Add(this.panelAdvanced);
            this.panel2.Controls.Add(this.uiPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 753);
            this.panel2.TabIndex = 1;
            // 
            // dgvPEDM
            // 
            this.dgvPEDM.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvPEDM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPEDM.AutoGenerateContextFilters = true;
            this.dgvPEDM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPEDM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPEDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPEDM.ContextMenuStrip = this.contextSelectRow;
            this.dgvPEDM.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPEDM.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPEDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPEDM.EnableHeadersVisualStyles = false;
            this.dgvPEDM.Location = new System.Drawing.Point(473, 71);
            this.dgvPEDM.Name = "dgvPEDM";
            this.dgvPEDM.RowHeadersVisible = false;
            this.dgvPEDM.Size = new System.Drawing.Size(1058, 682);
            this.dgvPEDM.TabIndex = 1;
            this.dgvPEDM.TimeFilter = false;
            this.dgvPEDM.SortStringChanged += new System.EventHandler(this.dgvPEDM_SortStringChanged);
            this.dgvPEDM.FilterStringChanged += new System.EventHandler(this.dgvPEDM_FilterStringChanged);
            this.dgvPEDM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPEDM_CellClick);
            // 
            // contextSelectRow
            // 
            this.contextSelectRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uptoolStripMenuItem,
            this.DelToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.contextSelectRow.Name = "contextSelectRow";
            this.contextSelectRow.Size = new System.Drawing.Size(113, 70);
            this.contextSelectRow.Opening += new System.ComponentModel.CancelEventHandler(this.contextSelectRow_Opening);
            // 
            // uptoolStripMenuItem
            // 
            this.uptoolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.update;
            this.uptoolStripMenuItem.Name = "uptoolStripMenuItem";
            this.uptoolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uptoolStripMenuItem.Text = "Update";
            this.uptoolStripMenuItem.Click += new System.EventHandler(this.uptoolStripMenuItem_Click_1);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.delete;
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DelToolStripMenuItem.Text = "Delete";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.adds;
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // panelShowFormAdd
            // 
            this.panelShowFormAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShowFormAdd.Location = new System.Drawing.Point(0, 71);
            this.panelShowFormAdd.Name = "panelShowFormAdd";
            this.panelShowFormAdd.Size = new System.Drawing.Size(473, 682);
            this.panelShowFormAdd.TabIndex = 5;
            this.panelShowFormAdd.Visible = false;
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Controls.Add(this.pictureBox1);
            this.panelAdvanced.Controls.Add(this.dateTo);
            this.panelAdvanced.Controls.Add(this.dateFrom);
            this.panelAdvanced.Controls.Add(this.uiMarkLabel1);
            this.panelAdvanced.Controls.Add(this.cbIssue);
            this.panelAdvanced.Controls.Add(this.intBox);
            this.panelAdvanced.Controls.Add(this.uiMarkLabel3);
            this.panelAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelAdvanced.Location = new System.Drawing.Point(0, 36);
            this.panelAdvanced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAdvanced.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(1531, 35);
            this.panelAdvanced.TabIndex = 85;
            this.panelAdvanced.Text = null;
            this.panelAdvanced.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelAdvanced.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(547, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // dateTo
            // 
            this.dateTo.FillColor = System.Drawing.Color.White;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTo.Location = new System.Drawing.Point(583, 3);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTo.MaxLength = 10;
            this.dateTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTo.Size = new System.Drawing.Size(119, 29);
            this.dateTo.SymbolDropDown = 61555;
            this.dateTo.SymbolNormal = 61555;
            this.dateTo.TabIndex = 84;
            this.dateTo.Text = "2023-12-19";
            this.dateTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTo.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateTo.Watermark = "";
            // 
            // dateFrom
            // 
            this.dateFrom.FillColor = System.Drawing.Color.White;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFrom.Location = new System.Drawing.Point(424, 3);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFrom.MaxLength = 10;
            this.dateFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateFrom.Size = new System.Drawing.Size(119, 29);
            this.dateFrom.SymbolDropDown = 61555;
            this.dateFrom.SymbolNormal = 61555;
            this.dateFrom.TabIndex = 83;
            this.dateFrom.Text = "2023-12-19";
            this.dateFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateFrom.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateFrom.Watermark = "";
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMarkLabel1.Location = new System.Drawing.Point(4, 6);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(72, 23);
            this.uiMarkLabel1.TabIndex = 78;
            this.uiMarkLabel1.Text = "Record";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbIssue
            // 
            this.cbIssue.DataSource = null;
            this.cbIssue.FillColor = System.Drawing.Color.White;
            this.cbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIssue.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbIssue.Items.AddRange(new object[] {
            "PUR",
            "ALL"});
            this.cbIssue.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbIssue.Location = new System.Drawing.Point(336, 3);
            this.cbIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIssue.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbIssue.Name = "cbIssue";
            this.cbIssue.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbIssue.Size = new System.Drawing.Size(84, 29);
            this.cbIssue.TabIndex = 82;
            this.cbIssue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbIssue.Watermark = "";
            // 
            // intBox
            // 
            this.intBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.intBox.Location = new System.Drawing.Point(83, 3);
            this.intBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.intBox.Name = "intBox";
            this.intBox.ShowText = false;
            this.intBox.Size = new System.Drawing.Size(156, 29);
            this.intBox.TabIndex = 79;
            this.intBox.Text = "uiIntegerUpDown1";
            this.intBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.intBox.Value = 1000;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMarkLabel3.Location = new System.Drawing.Point(246, 7);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(85, 23);
            this.uiMarkLabel3.TabIndex = 81;
            this.uiMarkLabel3.Text = "Issue To:";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.btnCheckUpdate);
            this.uiPanel1.Controls.Add(this.btnAdvanced);
            this.uiPanel1.Controls.Add(this.cbSelectTypeSearch);
            this.uiPanel1.Controls.Add(this.txtSearchContent);
            this.uiPanel1.Controls.Add(this.btnAdd);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1531, 36);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.view1;
            this.btnSearch.Location = new System.Drawing.Point(364, 4);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "Search";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(25)))));
            this.btnCheckUpdate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnCheckUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheckUpdate.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.check1;
            this.btnCheckUpdate.Location = new System.Drawing.Point(631, 4);
            this.btnCheckUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Radius = 10;
            this.btnCheckUpdate.Size = new System.Drawing.Size(137, 29);
            this.btnCheckUpdate.TabIndex = 83;
            this.btnCheckUpdate.Text = "Check Update";
            this.btnCheckUpdate.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanced.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAdvanced.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.sys;
            this.btnAdvanced.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAdvanced.Location = new System.Drawing.Point(513, 8);
            this.btnAdvanced.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAdvanced.Size = new System.Drawing.Size(105, 23);
            this.btnAdvanced.TabIndex = 39;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // cbSelectTypeSearch
            // 
            this.cbSelectTypeSearch.DataSource = null;
            this.cbSelectTypeSearch.FillColor = System.Drawing.Color.White;
            this.cbSelectTypeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSelectTypeSearch.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSelectTypeSearch.Items.AddRange(new object[] {
            "ECN",
            "ECO",
            "Model",
            "NO",
            "Duplicate ECO"});
            this.cbSelectTypeSearch.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSelectTypeSearch.Location = new System.Drawing.Point(4, 4);
            this.cbSelectTypeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSelectTypeSearch.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSelectTypeSearch.Name = "cbSelectTypeSearch";
            this.cbSelectTypeSearch.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSelectTypeSearch.Size = new System.Drawing.Size(183, 29);
            this.cbSelectTypeSearch.TabIndex = 10;
            this.cbSelectTypeSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSelectTypeSearch.Watermark = "";
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchContent.Location = new System.Drawing.Point(189, 4);
            this.txtSearchContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchContent.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchContent.ShowText = false;
            this.txtSearchContent.Size = new System.Drawing.Size(173, 29);
            this.txtSearchContent.TabIndex = 9;
            this.txtSearchContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchContent.Watermark = "";
            this.txtSearchContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchContent_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(464, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormPEDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 753);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPEDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPEDM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPEDM_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPEDM)).EndInit();
            this.contextSelectRow.ResumeLayout(false);
            this.panelAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceECO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private ADGV.AdvancedDataGridView dgvPEDM;
        private System.Windows.Forms.BindingSource bindingSourceECO;
        private System.Windows.Forms.ContextMenuStrip contextSelectRow;
        private System.Windows.Forms.ToolStripMenuItem uptoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cbSelectTypeSearch;
        private Sunny.UI.UITextBox txtSearchContent;
        private Sunny.UI.UIMarkLabel btnAdvanced;
        private Sunny.UI.UIIntegerUpDown intBox;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIComboBox cbIssue;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private System.Windows.Forms.Panel panelShowFormAdd;
        private Sunny.UI.UISymbolButton btnCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private Sunny.UI.UISymbolButton btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIDatePicker dateTo;
        private Sunny.UI.UIDatePicker dateFrom;
        private Sunny.UI.UIPanel panelAdvanced;
    }
}