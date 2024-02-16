
namespace ECO_DX_For_PUR.GUI
{
    partial class FormConfigs
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
            this.txtECOControlSheetCanon = new Sunny.UI.UITextBox();
            this.txtECNCanonPurchase = new Sunny.UI.UITextBox();
            this.txtMaster = new Sunny.UI.UITextBox();
            this.btnApply = new Sunny.UI.UISymbolButton();
            this.btnOpenMaster = new Sunny.UI.UISymbolButton();
            this.btnOpenECNCanonPurchase = new Sunny.UI.UISymbolButton();
            this.btnOpenECOControlSheetCanon = new Sunny.UI.UISymbolButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.SuspendLayout();
            // 
            // txtECOControlSheetCanon
            // 
            this.txtECOControlSheetCanon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtECOControlSheetCanon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECOControlSheetCanon.Location = new System.Drawing.Point(12, 40);
            this.txtECOControlSheetCanon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtECOControlSheetCanon.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtECOControlSheetCanon.Name = "txtECOControlSheetCanon";
            this.txtECOControlSheetCanon.Padding = new System.Windows.Forms.Padding(5);
            this.txtECOControlSheetCanon.ShowText = false;
            this.txtECOControlSheetCanon.Size = new System.Drawing.Size(502, 25);
            this.txtECOControlSheetCanon.TabIndex = 3;
            this.txtECOControlSheetCanon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtECOControlSheetCanon.Watermark = "";
            // 
            // txtECNCanonPurchase
            // 
            this.txtECNCanonPurchase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtECNCanonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECNCanonPurchase.Location = new System.Drawing.Point(248, 123);
            this.txtECNCanonPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtECNCanonPurchase.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtECNCanonPurchase.Name = "txtECNCanonPurchase";
            this.txtECNCanonPurchase.Padding = new System.Windows.Forms.Padding(5);
            this.txtECNCanonPurchase.ShowText = false;
            this.txtECNCanonPurchase.Size = new System.Drawing.Size(502, 25);
            this.txtECNCanonPurchase.TabIndex = 4;
            this.txtECNCanonPurchase.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtECNCanonPurchase.Visible = false;
            this.txtECNCanonPurchase.Watermark = "";
            // 
            // txtMaster
            // 
            this.txtMaster.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaster.Location = new System.Drawing.Point(248, 169);
            this.txtMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaster.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaster.ShowText = false;
            this.txtMaster.Size = new System.Drawing.Size(502, 25);
            this.txtMaster.TabIndex = 5;
            this.txtMaster.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaster.Visible = false;
            this.txtMaster.Watermark = "";
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnApply.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnApply.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.save;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(199, 70);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnApply.Radius = 15;
            this.btnApply.Size = new System.Drawing.Size(100, 35);
            this.btnApply.Style = Sunny.UI.UIStyle.Custom;
            this.btnApply.StyleCustomMode = true;
            this.btnApply.Symbol = 61530;
            this.btnApply.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnApply.TabIndex = 117;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOpenMaster
            // 
            this.btnOpenMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMaster.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOpenMaster.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.openfile;
            this.btnOpenMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenMaster.Location = new System.Drawing.Point(769, 173);
            this.btnOpenMaster.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenMaster.Name = "btnOpenMaster";
            this.btnOpenMaster.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnOpenMaster.Radius = 15;
            this.btnOpenMaster.Size = new System.Drawing.Size(34, 25);
            this.btnOpenMaster.Style = Sunny.UI.UIStyle.Custom;
            this.btnOpenMaster.StyleCustomMode = true;
            this.btnOpenMaster.Symbol = 61530;
            this.btnOpenMaster.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOpenMaster.TabIndex = 116;
            this.btnOpenMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenMaster.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenMaster.Visible = false;
            this.btnOpenMaster.Click += new System.EventHandler(this.btnOpenMaster_Click);
            // 
            // btnOpenECNCanonPurchase
            // 
            this.btnOpenECNCanonPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenECNCanonPurchase.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOpenECNCanonPurchase.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.openfile;
            this.btnOpenECNCanonPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenECNCanonPurchase.Location = new System.Drawing.Point(769, 126);
            this.btnOpenECNCanonPurchase.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenECNCanonPurchase.Name = "btnOpenECNCanonPurchase";
            this.btnOpenECNCanonPurchase.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnOpenECNCanonPurchase.Radius = 15;
            this.btnOpenECNCanonPurchase.Size = new System.Drawing.Size(34, 25);
            this.btnOpenECNCanonPurchase.Style = Sunny.UI.UIStyle.Custom;
            this.btnOpenECNCanonPurchase.StyleCustomMode = true;
            this.btnOpenECNCanonPurchase.Symbol = 61530;
            this.btnOpenECNCanonPurchase.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOpenECNCanonPurchase.TabIndex = 115;
            this.btnOpenECNCanonPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenECNCanonPurchase.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenECNCanonPurchase.Visible = false;
            this.btnOpenECNCanonPurchase.Click += new System.EventHandler(this.btnOpenECNCanonPurchase_Click);
            // 
            // btnOpenECOControlSheetCanon
            // 
            this.btnOpenECOControlSheetCanon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenECOControlSheetCanon.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnOpenECOControlSheetCanon.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.openfile;
            this.btnOpenECOControlSheetCanon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenECOControlSheetCanon.Location = new System.Drawing.Point(539, 40);
            this.btnOpenECOControlSheetCanon.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenECOControlSheetCanon.Name = "btnOpenECOControlSheetCanon";
            this.btnOpenECOControlSheetCanon.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btnOpenECOControlSheetCanon.Radius = 15;
            this.btnOpenECOControlSheetCanon.Size = new System.Drawing.Size(34, 25);
            this.btnOpenECOControlSheetCanon.Style = Sunny.UI.UIStyle.Custom;
            this.btnOpenECOControlSheetCanon.StyleCustomMode = true;
            this.btnOpenECOControlSheetCanon.Symbol = 61530;
            this.btnOpenECOControlSheetCanon.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOpenECOControlSheetCanon.TabIndex = 114;
            this.btnOpenECOControlSheetCanon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenECOControlSheetCanon.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenECOControlSheetCanon.Click += new System.EventHandler(this.btnOpenECOControlSheetCanon_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.Location = new System.Drawing.Point(136, 3);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(229, 29);
            this.uiLine1.TabIndex = 118;
            this.uiLine1.Text = "ECO control sheet Canon";
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.Location = new System.Drawing.Point(12, 119);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(229, 29);
            this.uiLine2.TabIndex = 119;
            this.uiLine2.Text = "ECN Canon Purchase";
            this.uiLine2.Visible = false;
            // 
            // uiLine3
            // 
            this.uiLine3.BackColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine3.Location = new System.Drawing.Point(12, 165);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(229, 29);
            this.uiLine3.TabIndex = 120;
            this.uiLine3.Text = "Master";
            this.uiLine3.Visible = false;
            // 
            // FormConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.uiLine3);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOpenMaster);
            this.Controls.Add(this.btnOpenECNCanonPurchase);
            this.Controls.Add(this.btnOpenECOControlSheetCanon);
            this.Controls.Add(this.txtMaster);
            this.Controls.Add(this.txtECNCanonPurchase);
            this.Controls.Add(this.txtECOControlSheetCanon);
            this.Name = "FormConfigs";
            this.Text = "FormConfigs";
            this.Load += new System.EventHandler(this.FormConfigs_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txtECOControlSheetCanon;
        private Sunny.UI.UITextBox txtECNCanonPurchase;
        private Sunny.UI.UITextBox txtMaster;
        private Sunny.UI.UISymbolButton btnOpenECOControlSheetCanon;
        private Sunny.UI.UISymbolButton btnOpenECNCanonPurchase;
        private Sunny.UI.UISymbolButton btnOpenMaster;
        private Sunny.UI.UISymbolButton btnApply;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
    }
}