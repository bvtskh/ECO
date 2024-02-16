
namespace ECO_DX_For_PUR.GUI
{
    partial class FormPrice
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
            this.txtPart = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.intBox = new Sunny.UI.UIIntegerUpDown();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.dgvPrice = new ADGV.AdvancedDataGridView();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.lbLastUpdate = new Sunny.UI.UIMarkLabel();
            this.btnUpdate = new Sunny.UI.UISymbolButton();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).BeginInit();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Part No";
            // 
            // txtPart
            // 
            this.txtPart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPart.Location = new System.Drawing.Point(70, 6);
            this.txtPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPart.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPart.Name = "txtPart";
            this.txtPart.Padding = new System.Windows.Forms.Padding(5);
            this.txtPart.Radius = 15;
            this.txtPart.ShowText = false;
            this.txtPart.Size = new System.Drawing.Size(210, 29);
            this.txtPart.TabIndex = 85;
            this.txtPart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPart.Watermark = "";
            this.txtPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPart_KeyDown);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.intBox);
            this.uiPanel1.Controls.Add(this.uiMarkLabel1);
            this.uiPanel1.Controls.Add(this.btnUpdate);
            this.uiPanel1.Controls.Add(this.txtPart);
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1487, 40);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intBox
            // 
            this.intBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.intBox.Location = new System.Drawing.Point(575, 6);
            this.intBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.intBox.Name = "intBox";
            this.intBox.ShowText = false;
            this.intBox.Size = new System.Drawing.Size(116, 29);
            this.intBox.TabIndex = 88;
            this.intBox.Text = "uiIntegerUpDown1";
            this.intBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.intBox.Value = 1000;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMarkLabel1.Location = new System.Drawing.Point(496, 10);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(74, 23);
            this.uiMarkLabel1.TabIndex = 87;
            this.uiMarkLabel1.Text = "Record";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.dgvPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrice.AutoGenerateContextFilters = true;
            this.dgvPrice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrice.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrice.EnableHeadersVisualStyles = false;
            this.dgvPrice.Location = new System.Drawing.Point(0, 40);
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.RowHeadersVisible = false;
            this.dgvPrice.Size = new System.Drawing.Size(1487, 568);
            this.dgvPrice.TabIndex = 0;
            this.dgvPrice.TimeFilter = false;
            this.dgvPrice.SortStringChanged += new System.EventHandler(this.dgvPrice_SortStringChanged);
            this.dgvPrice.FilterStringChanged += new System.EventHandler(this.dgvPrice_FilterStringChanged);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.lbLastUpdate);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 608);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1487, 41);
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLastUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbLastUpdate.Location = new System.Drawing.Point(3, 9);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbLastUpdate.Size = new System.Drawing.Size(439, 23);
            this.lbLastUpdate.TabIndex = 0;
            this.lbLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.exel;
            this.btnUpdate.Location = new System.Drawing.Point(389, 6);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(102, 29);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.Bisque;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.view1;
            this.btnSearch.Location = new System.Drawing.Point(283, 6);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(102, 29);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "Search";
            this.btnSearch.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 649);
            this.Controls.Add(this.dgvPrice);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrice";
            this.Text = "FormPrice";
            this.Load += new System.EventHandler(this.FormPrice_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrice)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UITextBox txtPart;
        private Sunny.UI.UIPanel uiPanel1;
        private ADGV.AdvancedDataGridView dgvPrice;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIMarkLabel lbLastUpdate;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Sunny.UI.UIIntegerUpDown intBox;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolButton btnSearch;
    }
}