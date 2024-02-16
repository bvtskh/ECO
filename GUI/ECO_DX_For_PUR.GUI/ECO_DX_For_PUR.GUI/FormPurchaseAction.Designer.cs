
namespace ECO_DX_For_PUR.GUI
{
    partial class FormPurchaseAction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtECN = new System.Windows.Forms.TextBox();
            this.dgvAction = new ADGV.AdvancedDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.cbModel = new Sunny.UI.UIComboBox();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.btnCopy = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.btnReplaceSituation = new Sunny.UI.UISymbolButton();
            this.cbSituation = new Sunny.UI.UIComboBox();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnExport = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.btnMultiSelect = new System.Windows.Forms.PictureBox();
            this.bindingAction = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMultiSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ECN input";
            // 
            // txtECN
            // 
            this.txtECN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECN.Location = new System.Drawing.Point(3, 6);
            this.txtECN.Name = "txtECN";
            this.txtECN.Size = new System.Drawing.Size(221, 27);
            this.txtECN.TabIndex = 24;
            this.txtECN.TextChanged += new System.EventHandler(this.txtECN_TextChanged);
            // 
            // dgvAction
            // 
            this.dgvAction.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvAction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAction.AutoGenerateContextFilters = true;
            this.dgvAction.BackgroundColor = System.Drawing.Color.White;
            this.dgvAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAction.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAction.EnableHeadersVisualStyles = false;
            this.dgvAction.Location = new System.Drawing.Point(0, 38);
            this.dgvAction.Name = "dgvAction";
            this.dgvAction.RowHeadersVisible = false;
            this.dgvAction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAction.Size = new System.Drawing.Size(1519, 607);
            this.dgvAction.TabIndex = 4;
            this.dgvAction.TimeFilter = false;
            this.dgvAction.SortStringChanged += new System.EventHandler(this.dgvAction_SortStringChanged);
            this.dgvAction.FilterStringChanged += new System.EventHandler(this.dgvAction_FilterStringChanged);
            this.dgvAction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAction_CellFormatting);
            this.dgvAction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAction_CellValueChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.cbModel);
            this.uiPanel1.Controls.Add(this.uiSymbolButton3);
            this.uiPanel1.Controls.Add(this.btnCopy);
            this.uiPanel1.Controls.Add(this.uiSymbolButton1);
            this.uiPanel1.Controls.Add(this.btnReplaceSituation);
            this.uiPanel1.Controls.Add(this.cbSituation);
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.btnExport);
            this.uiPanel1.Controls.Add(this.btnSave);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Controls.Add(this.txtECN);
            this.uiPanel1.Controls.Add(this.btnMultiSelect);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1519, 38);
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbModel
            // 
            this.cbModel.DataSource = null;
            this.cbModel.FillColor = System.Drawing.Color.White;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbModel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbModel.Items.AddRange(new object[] {
            "No apply-same price",
            "No apply-model no demand",
            "No apply-model EOL",
            "No apply-new part EOL",
            "No apply-high price",
            "No apply-child part no use this model",
            "Have schedule apply already-running change",
            "Have schedule apply already-change original",
            "Not yet have TVP result",
            "customer not yet instruct ratio",
            "Checking-Asking QTN",
            "others"});
            this.cbModel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbModel.Location = new System.Drawing.Point(8, 42);
            this.cbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbModel.Name = "cbModel";
            this.cbModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbModel.Size = new System.Drawing.Size(132, 29);
            this.cbModel.TabIndex = 131;
            this.cbModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbModel.Watermark = "";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Crimson;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.check;
            this.uiSymbolButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton3.Location = new System.Drawing.Point(234, 42);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton3.Size = new System.Drawing.Size(104, 29);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.StyleCustomMode = true;
            this.uiSymbolButton3.Symbol = 61530;
            this.uiSymbolButton3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolButton3.TabIndex = 130;
            this.uiSymbolButton3.Text = "model";
            this.uiSymbolButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton3.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FillColor = System.Drawing.Color.SkyBlue;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCopy.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.search;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(144, 42);
            this.btnCopy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnCopy.Size = new System.Drawing.Size(85, 29);
            this.btnCopy.Style = Sunny.UI.UIStyle.Custom;
            this.btnCopy.StyleCustomMode = true;
            this.btnCopy.Symbol = 61530;
            this.btnCopy.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnCopy.TabIndex = 129;
            this.btnCopy.Text = "copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopy.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.update;
            this.uiSymbolButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton1.Location = new System.Drawing.Point(12, 79);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton1.Size = new System.Drawing.Size(108, 29);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.StyleCustomMode = true;
            this.uiSymbolButton1.Symbol = 61530;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiSymbolButton1.TabIndex = 126;
            this.uiSymbolButton1.Text = "Update";
            this.uiSymbolButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnReplaceSituation
            // 
            this.btnReplaceSituation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceSituation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(25)))), ((int)(((byte)(129)))));
            this.btnReplaceSituation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.btnReplaceSituation.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnReplaceSituation.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.update;
            this.btnReplaceSituation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceSituation.Location = new System.Drawing.Point(788, 4);
            this.btnReplaceSituation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReplaceSituation.Name = "btnReplaceSituation";
            this.btnReplaceSituation.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnReplaceSituation.Size = new System.Drawing.Size(106, 29);
            this.btnReplaceSituation.Style = Sunny.UI.UIStyle.Custom;
            this.btnReplaceSituation.StyleCustomMode = true;
            this.btnReplaceSituation.Symbol = 61530;
            this.btnReplaceSituation.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnReplaceSituation.TabIndex = 125;
            this.btnReplaceSituation.Text = "Replace";
            this.btnReplaceSituation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReplaceSituation.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReplaceSituation.Click += new System.EventHandler(this.btnReplaceSituation_Click);
            // 
            // cbSituation
            // 
            this.cbSituation.DataSource = null;
            this.cbSituation.FillColor = System.Drawing.Color.White;
            this.cbSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSituation.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSituation.Items.AddRange(new object[] {
            "No apply-same price",
            "No apply-model no demand",
            "No apply-model EOL",
            "No apply-new part EOL",
            "No apply-high price",
            "No apply-child part no use this model",
            "Have schedule apply already-running change",
            "Have schedule apply already-change original",
            "Not yet have TVP result",
            "customer not yet instruct ratio",
            "Checking-Asking QTN",
            "others"});
            this.cbSituation.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSituation.Location = new System.Drawing.Point(549, 4);
            this.cbSituation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSituation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSituation.Name = "cbSituation";
            this.cbSituation.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSituation.Size = new System.Drawing.Size(236, 29);
            this.cbSituation.TabIndex = 124;
            this.cbSituation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSituation.Watermark = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(153)))), ((int)(((byte)(13)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSearch.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(259, 4);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnSearch.Size = new System.Drawing.Size(100, 29);
            this.btnSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnSearch.StyleCustomMode = true;
            this.btnSearch.Symbol = 61530;
            this.btnSearch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSearch.TabIndex = 117;
            this.btnSearch.Text = "Action";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExport.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.exel;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(447, 4);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnExport.Size = new System.Drawing.Size(99, 29);
            this.btnExport.Style = Sunny.UI.UIStyle.Custom;
            this.btnExport.StyleCustomMode = true;
            this.btnExport.Symbol = 61530;
            this.btnExport.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.TabIndex = 115;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSave.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.sdb;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(362, 4);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.StyleCustomMode = true;
            this.btnSave.Symbol = 61530;
            this.btnSave.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMultiSelect
            // 
            this.btnMultiSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiSelect.BackgroundImage = global::ECO_DX_For_PUR.GUI.Properties.Resources.down;
            this.btnMultiSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiSelect.Location = new System.Drawing.Point(228, 6);
            this.btnMultiSelect.Name = "btnMultiSelect";
            this.btnMultiSelect.Size = new System.Drawing.Size(27, 26);
            this.btnMultiSelect.TabIndex = 22;
            this.btnMultiSelect.TabStop = false;
            this.btnMultiSelect.Click += new System.EventHandler(this.btnMultiSelect_Click);
            // 
            // FormPurchaseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 645);
            this.Controls.Add(this.dgvAction);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormPurchaseAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPurchaseAction";
            this.Load += new System.EventHandler(this.FormPurchaseAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAction)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMultiSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ADGV.AdvancedDataGridView dgvAction;
        private System.Windows.Forms.PictureBox btnMultiSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtECN;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnExport;
        private Sunny.UI.UISymbolButton btnSearch;
        private System.Windows.Forms.BindingSource bindingAction;
        private Sunny.UI.UIComboBox cbSituation;
        private Sunny.UI.UISymbolButton btnReplaceSituation;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton btnCopy;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIComboBox cbModel;
    }
}