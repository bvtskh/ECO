namespace ECO_DX_For_PUR.GUI
{
    partial class FormPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchase));
            this.dgvPurchase = new ADGV.AdvancedDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.purchaseActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectECNFinishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPDFECOChangeNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbSearch = new Sunny.UI.UIComboBox();
            this.txtSearchString = new Sunny.UI.UITextBox();
            this.cbSelectType = new Sunny.UI.UIComboBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnAdvanced = new Sunny.UI.UIMarkLabel();
            this.btnView = new System.Windows.Forms.Button();
            this.dateTo = new Sunny.UI.UIDatePicker();
            this.dateFrom = new Sunny.UI.UIDatePicker();
            this.intBox = new Sunny.UI.UIIntegerUpDown();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingPending = new System.Windows.Forms.BindingSource(this.components);
            this.bindingFinish = new System.Windows.Forms.BindingSource(this.components);
            this.bindingDuplicate = new System.Windows.Forms.BindingSource(this.components);
            this.panelAdvanced = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDuplicate)).BeginInit();
            this.panelAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.AutoGenerateContextFilters = true;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPurchase.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchase.EnableHeadersVisualStyles = false;
            this.dgvPurchase.Location = new System.Drawing.Point(0, 76);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersVisible = false;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(1772, 575);
            this.dgvPurchase.TabIndex = 1;
            this.dgvPurchase.TimeFilter = false;
            this.dgvPurchase.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.dgvPurchase.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvECNSetting_CellClick);
            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvECNSetting_CellContentClick);
            this.dgvPurchase.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.advancedDataGridView1_CellFormatting);
            this.dgvPurchase.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvECNSetting_CellValueChanged);
            this.dgvPurchase.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvECNSetting_CurrentCellDirtyStateChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseActionToolStripMenuItem,
            this.selectECNFinishedToolStripMenuItem,
            this.pPDFECOChangeNoticeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // purchaseActionToolStripMenuItem
            // 
            this.purchaseActionToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.write;
            this.purchaseActionToolStripMenuItem.Name = "purchaseActionToolStripMenuItem";
            this.purchaseActionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.purchaseActionToolStripMenuItem.Text = "Purchase Action";
            this.purchaseActionToolStripMenuItem.Click += new System.EventHandler(this.purchaseActionToolStripMenuItem_Click);
            // 
            // selectECNFinishedToolStripMenuItem
            // 
            this.selectECNFinishedToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.check1;
            this.selectECNFinishedToolStripMenuItem.Name = "selectECNFinishedToolStripMenuItem";
            this.selectECNFinishedToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selectECNFinishedToolStripMenuItem.Text = "Select ECN Finished";
            this.selectECNFinishedToolStripMenuItem.Click += new System.EventHandler(this.selectECNFinishedToolStripMenuItem_Click);
            // 
            // pPDFECOChangeNoticeToolStripMenuItem
            // 
            this.pPDFECOChangeNoticeToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.pdf;
            this.pPDFECOChangeNoticeToolStripMenuItem.Name = "pPDFECOChangeNoticeToolStripMenuItem";
            this.pPDFECOChangeNoticeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pPDFECOChangeNoticeToolStripMenuItem.Text = "PDF ECO Change Notice";
            this.pPDFECOChangeNoticeToolStripMenuItem.Click += new System.EventHandler(this.pPDFECOChangeNoticeToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1422, 71);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 71);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.DataSource = null;
            this.cbSearch.FillColor = System.Drawing.Color.White;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbSearch.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSearch.Items.AddRange(new object[] {
            "ECN",
            "ECO"});
            this.cbSearch.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSearch.Location = new System.Drawing.Point(303, 4);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearch.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSearch.Size = new System.Drawing.Size(81, 29);
            this.cbSearch.TabIndex = 71;
            this.cbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSearch.Watermark = "";
            // 
            // txtSearchString
            // 
            this.txtSearchString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchString.Location = new System.Drawing.Point(468, 4);
            this.txtSearchString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchString.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchString.ShowText = false;
            this.txtSearchString.Size = new System.Drawing.Size(132, 29);
            this.txtSearchString.TabIndex = 73;
            this.txtSearchString.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchString.Watermark = "";
            this.txtSearchString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchString_KeyDown);
            // 
            // cbSelectType
            // 
            this.cbSelectType.DataSource = null;
            this.cbSelectType.FillColor = System.Drawing.Color.White;
            this.cbSelectType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSelectType.Items.AddRange(new object[] {
            "Finish",
            "Pending",
            "Duplicate ECO"});
            this.cbSelectType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSelectType.Location = new System.Drawing.Point(7, 6);
            this.cbSelectType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSelectType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSelectType.Name = "cbSelectType";
            this.cbSelectType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSelectType.Size = new System.Drawing.Size(156, 29);
            this.cbSelectType.TabIndex = 72;
            this.cbSelectType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSelectType.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.cbSelectType);
            this.uiPanel1.Controls.Add(this.btnAdvanced);
            this.uiPanel1.Controls.Add(this.btnView);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1772, 40);
            this.uiPanel1.TabIndex = 73;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanced.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAdvanced.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.sys;
            this.btnAdvanced.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAdvanced.Location = new System.Drawing.Point(276, 9);
            this.btnAdvanced.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAdvanced.Size = new System.Drawing.Size(110, 23);
            this.btnAdvanced.TabIndex = 38;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Bisque;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.view1;
            this.btnView.Location = new System.Drawing.Point(167, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(93, 29);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Search";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dateTo
            // 
            this.dateTo.FillColor = System.Drawing.Color.White;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTo.Location = new System.Drawing.Point(761, 4);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTo.MaxLength = 10;
            this.dateTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTo.Size = new System.Drawing.Size(119, 29);
            this.dateTo.SymbolDropDown = 61555;
            this.dateTo.SymbolNormal = 61555;
            this.dateTo.TabIndex = 79;
            this.dateTo.Text = "2023-12-19";
            this.dateTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTo.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateTo.Watermark = "";
            // 
            // dateFrom
            // 
            this.dateFrom.FillColor = System.Drawing.Color.White;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFrom.Location = new System.Drawing.Point(603, 4);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFrom.MaxLength = 10;
            this.dateFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateFrom.Size = new System.Drawing.Size(119, 29);
            this.dateFrom.SymbolDropDown = 61555;
            this.dateFrom.SymbolNormal = 61555;
            this.dateFrom.TabIndex = 78;
            this.dateFrom.Text = "2023-12-19";
            this.dateFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateFrom.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateFrom.Watermark = "";
            // 
            // intBox
            // 
            this.intBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.intBox.Location = new System.Drawing.Point(85, 4);
            this.intBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.intBox.Name = "intBox";
            this.intBox.ShowText = false;
            this.intBox.Size = new System.Drawing.Size(116, 29);
            this.intBox.TabIndex = 77;
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
            this.uiMarkLabel3.Location = new System.Drawing.Point(387, 7);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(77, 23);
            this.uiMarkLabel3.TabIndex = 76;
            this.uiMarkLabel3.Text = "Content";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMarkLabel2.Location = new System.Drawing.Point(204, 7);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(98, 23);
            this.uiMarkLabel2.TabIndex = 75;
            this.uiMarkLabel2.Text = "Search by";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMarkLabel1.Location = new System.Drawing.Point(6, 7);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(74, 23);
            this.uiMarkLabel1.TabIndex = 74;
            this.uiMarkLabel1.Text = "Record";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(725, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.view1;
            this.button1.Location = new System.Drawing.Point(1315, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 73;
            this.button1.Text = "First ZMM80";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.BurlyWood;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1501, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 35);
            this.button5.TabIndex = 17;
            this.button5.Text = "first import control sheet";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Controls.Add(this.button5);
            this.panelAdvanced.Controls.Add(this.button1);
            this.panelAdvanced.Controls.Add(this.pictureBox1);
            this.panelAdvanced.Controls.Add(this.intBox);
            this.panelAdvanced.Controls.Add(this.txtSearchString);
            this.panelAdvanced.Controls.Add(this.dateTo);
            this.panelAdvanced.Controls.Add(this.uiMarkLabel1);
            this.panelAdvanced.Controls.Add(this.dateFrom);
            this.panelAdvanced.Controls.Add(this.cbSearch);
            this.panelAdvanced.Controls.Add(this.uiMarkLabel2);
            this.panelAdvanced.Controls.Add(this.uiMarkLabel3);
            this.panelAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdvanced.Location = new System.Drawing.Point(0, 40);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(1772, 36);
            this.panelAdvanced.TabIndex = 75;
            this.panelAdvanced.Visible = false;
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1772, 651);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDuplicate)).EndInit();
            this.panelAdvanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ADGV.AdvancedDataGridView dgvPurchase;
        private System.Windows.Forms.BindingSource bindingPending;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bindingFinish;
        private System.Windows.Forms.BindingSource bindingDuplicate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseActionToolStripMenuItem;
        private Sunny.UI.UIMarkLabel btnAdvanced;
        private Sunny.UI.UITextBox txtSearchString;
        private Sunny.UI.UIComboBox cbSearch;
        private Sunny.UI.UIComboBox cbSelectType;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIIntegerUpDown intBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIDatePicker dateTo;
        private Sunny.UI.UIDatePicker dateFrom;
        private System.Windows.Forms.ToolStripMenuItem selectECNFinishedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPDFECOChangeNoticeToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdvanced;
    }
}

