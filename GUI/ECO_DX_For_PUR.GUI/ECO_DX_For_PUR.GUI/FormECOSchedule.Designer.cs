
namespace ECO_DX_For_PUR.GUI
{
    partial class FormECOSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTo = new Sunny.UI.UIDatePicker();
            this.dateFrom = new Sunny.UI.UIDatePicker();
            this.checkboxPending = new Sunny.UI.UICheckBox();
            this.lblStatus = new Sunny.UI.UILabel();
            this.btnExport = new Sunny.UI.UISymbolButton();
            this.btnInsert = new Sunny.UI.UISymbolButton();
            this.dgvECO_Schedule = new ADGV.AdvancedDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvECO_Schedule)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.checkboxPending);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 41);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(460, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // dateTo
            // 
            this.dateTo.FillColor = System.Drawing.Color.White;
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTo.Location = new System.Drawing.Point(496, 6);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTo.MaxLength = 10;
            this.dateTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTo.Size = new System.Drawing.Size(119, 29);
            this.dateTo.SymbolDropDown = 61555;
            this.dateTo.SymbolNormal = 61555;
            this.dateTo.TabIndex = 120;
            this.dateTo.Text = "2023-12-19";
            this.dateTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTo.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateTo.Watermark = "";
            this.dateTo.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.date_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.FillColor = System.Drawing.Color.White;
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFrom.Location = new System.Drawing.Point(338, 6);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFrom.MaxLength = 10;
            this.dateFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateFrom.Size = new System.Drawing.Size(119, 29);
            this.dateFrom.SymbolDropDown = 61555;
            this.dateFrom.SymbolNormal = 61555;
            this.dateFrom.TabIndex = 119;
            this.dateFrom.Text = "2023-12-19";
            this.dateFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateFrom.Value = new System.DateTime(2023, 12, 19, 11, 43, 23, 302);
            this.dateFrom.Watermark = "";
            this.dateFrom.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.date_ValueChanged);
            // 
            // checkboxPending
            // 
            this.checkboxPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkboxPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkboxPending.Location = new System.Drawing.Point(232, 6);
            this.checkboxPending.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkboxPending.Name = "checkboxPending";
            this.checkboxPending.Size = new System.Drawing.Size(89, 29);
            this.checkboxPending.TabIndex = 118;
            this.checkboxPending.Text = "Pending";
            this.checkboxPending.CheckedChanged += new System.EventHandler(this.checkboxPending_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblStatus.Location = new System.Drawing.Point(1255, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 23);
            this.lblStatus.TabIndex = 117;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(44)))), ((int)(((byte)(22)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExport.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.exel;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(112, 6);
            this.btnExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnExport.Size = new System.Drawing.Size(99, 29);
            this.btnExport.Style = Sunny.UI.UIStyle.Custom;
            this.btnExport.StyleCustomMode = true;
            this.btnExport.Symbol = 61530;
            this.btnExport.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnExport.TabIndex = 116;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsert.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.adds;
            this.btnInsert.Location = new System.Drawing.Point(6, 6);
            this.btnInsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 29);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvECO_Schedule
            // 
            this.dgvECO_Schedule.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvECO_Schedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvECO_Schedule.AutoGenerateContextFilters = true;
            this.dgvECO_Schedule.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvECO_Schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvECO_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvECO_Schedule.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvECO_Schedule.DateWithTime = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvECO_Schedule.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvECO_Schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvECO_Schedule.EnableHeadersVisualStyles = false;
            this.dgvECO_Schedule.Location = new System.Drawing.Point(0, 41);
            this.dgvECO_Schedule.Name = "dgvECO_Schedule";
            this.dgvECO_Schedule.RowHeadersVisible = false;
            this.dgvECO_Schedule.Size = new System.Drawing.Size(1370, 709);
            this.dgvECO_Schedule.TabIndex = 2;
            this.dgvECO_Schedule.TimeFilter = false;
            this.dgvECO_Schedule.SortStringChanged += new System.EventHandler(this.dgvECO_Schedule_SortStringChanged);
            this.dgvECO_Schedule.FilterStringChanged += new System.EventHandler(this.dgvECO_Schedule_FilterStringChanged);
            this.dgvECO_Schedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvECO_Schedule_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // FormECOSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.dgvECO_Schedule);
            this.Controls.Add(this.panel1);
            this.Name = "FormECOSchedule";
            this.Text = "FormECOSchedule";
            this.Load += new System.EventHandler(this.FormECOSchedule_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvECO_Schedule)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton btnInsert;
        private ADGV.AdvancedDataGridView dgvECO_Schedule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Sunny.UI.UISymbolButton btnExport;
        private Sunny.UI.UICheckBox checkboxPending;
        private Sunny.UI.UILabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIDatePicker dateTo;
        private Sunny.UI.UIDatePicker dateFrom;
    }
}