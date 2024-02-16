
namespace ECO_DX_For_PUR.GUI
{
    partial class FormWORelationship
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.btnExport = new Sunny.UI.UISymbolButton();
            this.dgvWO = new ADGV.AdvancedDataGridView();
            this.ctxWO = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertWOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPending = new Sunny.UI.UISwitch();
            this.cbCustomer = new Sunny.UI.UIComboBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWO)).BeginInit();
            this.ctxWO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.cbCustomer);
            this.uiPanel1.Controls.Add(this.checkBoxPending);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.btnExport);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1414, 38);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.AntiqueWhite;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.view1;
            this.btnSearch.Location = new System.Drawing.Point(290, 4);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(91, 29);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "Search";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btnExport.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExport.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.exel;
            this.btnExport.Location = new System.Drawing.Point(509, 5);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 10;
            this.btnExport.Size = new System.Drawing.Size(92, 29);
            this.btnExport.TabIndex = 88;
            this.btnExport.Text = "Export";
            this.btnExport.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvWO
            // 
            this.dgvWO.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvWO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWO.AutoGenerateContextFilters = true;
            this.dgvWO.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWO.ContextMenuStrip = this.ctxWO;
            this.dgvWO.DateWithTime = false;
            this.dgvWO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWO.EnableHeadersVisualStyles = false;
            this.dgvWO.Location = new System.Drawing.Point(0, 38);
            this.dgvWO.Name = "dgvWO";
            this.dgvWO.RowHeadersVisible = false;
            this.dgvWO.Size = new System.Drawing.Size(1414, 749);
            this.dgvWO.TabIndex = 3;
            this.dgvWO.TimeFilter = false;
            this.dgvWO.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.dgvWO.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.dgvWO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWO_CellClick);
            // 
            // ctxWO
            // 
            this.ctxWO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertWOToolStripMenuItem});
            this.ctxWO.Name = "ctxWO";
            this.ctxWO.Size = new System.Drawing.Size(127, 26);
            // 
            // insertWOToolStripMenuItem
            // 
            this.insertWOToolStripMenuItem.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.adds;
            this.insertWOToolStripMenuItem.Name = "insertWOToolStripMenuItem";
            this.insertWOToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.insertWOToolStripMenuItem.Text = "Insert WO";
            this.insertWOToolStripMenuItem.Click += new System.EventHandler(this.insertWOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Customer:";
            // 
            // checkBoxPending
            // 
            this.checkBoxPending.Active = true;
            this.checkBoxPending.ActiveColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxPending.ActiveText = "Pending";
            this.checkBoxPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxPending.InActiveColor = System.Drawing.Color.ForestGreen;
            this.checkBoxPending.InActiveText = "Success";
            this.checkBoxPending.Location = new System.Drawing.Point(390, 4);
            this.checkBoxPending.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxPending.Name = "checkBoxPending";
            this.checkBoxPending.Size = new System.Drawing.Size(113, 29);
            this.checkBoxPending.TabIndex = 93;
            this.checkBoxPending.Text = "uiSwitch1";
            this.checkBoxPending.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.checkBoxPending_ValueChanged);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = null;
            this.cbCustomer.FillColor = System.Drawing.Color.White;
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCustomer.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbCustomer.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbCustomer.Location = new System.Drawing.Point(95, 4);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomer.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCustomer.Size = new System.Drawing.Size(191, 29);
            this.cbCustomer.TabIndex = 94;
            this.cbCustomer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCustomer.Watermark = "";
            // 
            // FormWORelationship
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1414, 787);
            this.Controls.Add(this.dgvWO);
            this.Controls.Add(this.uiPanel1);
            this.Name = "FormWORelationship";
            this.Text = "FormWORelationship";
            this.Load += new System.EventHandler(this.FormWORelationship_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWO)).EndInit();
            this.ctxWO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private ADGV.AdvancedDataGridView dgvWO;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UISymbolButton btnExport;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip ctxWO;
        private System.Windows.Forms.ToolStripMenuItem insertWOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISwitch checkBoxPending;
        private Sunny.UI.UIComboBox cbCustomer;
    }
}