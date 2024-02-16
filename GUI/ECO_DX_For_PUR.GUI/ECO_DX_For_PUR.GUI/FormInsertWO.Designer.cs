
namespace ECO_DX_For_PUR.GUI
{
    partial class FormInsertWO
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImport = new Sunny.UI.UISymbolButton();
            this.lbModelName = new Sunny.UI.UIMarkLabel();
            this.lbNewPart = new Sunny.UI.UIMarkLabel();
            this.lbECO = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel4 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel11 = new Sunny.UI.UIMarkLabel();
            this.lbOldPart = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.lbContentchange = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel5 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel12 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel16 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel17 = new Sunny.UI.UIMarkLabel();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.panelImport = new System.Windows.Forms.Panel();
            this.rdo_2 = new Sunny.UI.UIRadioButton();
            this.rdo_1 = new Sunny.UI.UIRadioButton();
            this.rdo_0 = new Sunny.UI.UIRadioButton();
            this.grouptextbox = new Sunny.UI.UIGroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInsertWO = new System.Windows.Forms.Panel();
            this.txtAI = new Sunny.UI.UITextBox();
            this.txtSMTA = new Sunny.UI.UITextBox();
            this.txtSMTB = new Sunny.UI.UITextBox();
            this.txtSMT = new Sunny.UI.UITextBox();
            this.txtFAT1 = new Sunny.UI.UITextBox();
            this.txtFAT3 = new Sunny.UI.UITextBox();
            this.txtFAT2 = new Sunny.UI.UITextBox();
            this.txtAIQty = new Sunny.UI.UITextBox();
            this.txtSMTAQty = new Sunny.UI.UITextBox();
            this.txtSMTBQty = new Sunny.UI.UITextBox();
            this.txtFAT3Qty = new Sunny.UI.UITextBox();
            this.txtSMTQty = new Sunny.UI.UITextBox();
            this.txtFAT2Qty = new Sunny.UI.UITextBox();
            this.txtFAT1Qty = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtWOpending = new Sunny.UI.UITextBox();
            this.panelImport.SuspendLayout();
            this.grouptextbox.SuspendLayout();
            this.panelInsertWO.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(157, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 24);
            this.btnClear.TabIndex = 102;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Enabled = false;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.btnImport.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImport.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.exel;
            this.btnImport.Location = new System.Drawing.Point(3, 5);
            this.btnImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnImport.Name = "btnImport";
            this.btnImport.Radius = 10;
            this.btnImport.Size = new System.Drawing.Size(149, 29);
            this.btnImport.TabIndex = 101;
            this.btnImport.Text = "Import By Excel";
            this.btnImport.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lbModelName
            // 
            this.lbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbModelName.Location = new System.Drawing.Point(258, 43);
            this.lbModelName.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbModelName.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbModelName.Size = new System.Drawing.Size(79, 23);
            this.lbModelName.Style = Sunny.UI.UIStyle.Custom;
            this.lbModelName.TabIndex = 87;
            this.lbModelName.Text = "AI Qty";
            this.lbModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNewPart
            // 
            this.lbNewPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbNewPart.Location = new System.Drawing.Point(258, 77);
            this.lbNewPart.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbNewPart.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lbNewPart.Name = "lbNewPart";
            this.lbNewPart.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbNewPart.Size = new System.Drawing.Size(79, 23);
            this.lbNewPart.Style = Sunny.UI.UIStyle.Custom;
            this.lbNewPart.TabIndex = 89;
            this.lbNewPart.Text = "SMTA Qty";
            this.lbNewPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbECO
            // 
            this.lbECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbECO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbECO.Location = new System.Drawing.Point(8, 8);
            this.lbECO.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbECO.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lbECO.Name = "lbECO";
            this.lbECO.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbECO.Size = new System.Drawing.Size(79, 23);
            this.lbECO.Style = Sunny.UI.UIStyle.Custom;
            this.lbECO.TabIndex = 86;
            this.lbECO.Text = "AI WO";
            this.lbECO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel4.Location = new System.Drawing.Point(258, 111);
            this.uiMarkLabel4.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel4.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel4.TabIndex = 95;
            this.uiMarkLabel4.Text = "SMTB Qty";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel11
            // 
            this.uiMarkLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel11.Location = new System.Drawing.Point(258, 145);
            this.uiMarkLabel11.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel11.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel11.Name = "uiMarkLabel11";
            this.uiMarkLabel11.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel11.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel11.TabIndex = 115;
            this.uiMarkLabel11.Text = "SMT Qty";
            this.uiMarkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOldPart
            // 
            this.lbOldPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbOldPart.Location = new System.Drawing.Point(8, 42);
            this.lbOldPart.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbOldPart.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lbOldPart.Name = "lbOldPart";
            this.lbOldPart.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbOldPart.Size = new System.Drawing.Size(79, 23);
            this.lbOldPart.Style = Sunny.UI.UIStyle.Custom;
            this.lbOldPart.TabIndex = 88;
            this.lbOldPart.Text = "SMTA WO";
            this.lbOldPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.Location = new System.Drawing.Point(258, 179);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel2.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 97;
            this.uiMarkLabel2.Text = "FAT1 Qty";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbContentchange
            // 
            this.lbContentchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContentchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbContentchange.Location = new System.Drawing.Point(8, 76);
            this.lbContentchange.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbContentchange.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lbContentchange.Name = "lbContentchange";
            this.lbContentchange.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lbContentchange.Size = new System.Drawing.Size(79, 23);
            this.lbContentchange.Style = Sunny.UI.UIStyle.Custom;
            this.lbContentchange.TabIndex = 90;
            this.lbContentchange.Text = "SMTB WO";
            this.lbContentchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel5
            // 
            this.uiMarkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel5.Location = new System.Drawing.Point(258, 213);
            this.uiMarkLabel5.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel5.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel5.Name = "uiMarkLabel5";
            this.uiMarkLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel5.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel5.TabIndex = 100;
            this.uiMarkLabel5.Text = "FAT2 Qty";
            this.uiMarkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel12
            // 
            this.uiMarkLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel12.Location = new System.Drawing.Point(8, 110);
            this.uiMarkLabel12.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel12.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel12.Name = "uiMarkLabel12";
            this.uiMarkLabel12.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel12.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel12.TabIndex = 113;
            this.uiMarkLabel12.Text = "SMT WO";
            this.uiMarkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel16
            // 
            this.uiMarkLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel16.Location = new System.Drawing.Point(258, 247);
            this.uiMarkLabel16.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel16.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel16.Name = "uiMarkLabel16";
            this.uiMarkLabel16.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel16.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel16.TabIndex = 126;
            this.uiMarkLabel16.Text = "FAT3 Qty";
            this.uiMarkLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel3.Location = new System.Drawing.Point(8, 144);
            this.uiMarkLabel3.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel3.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel3.TabIndex = 96;
            this.uiMarkLabel3.Text = "FAT1 WO";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(8, 178);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 98;
            this.uiMarkLabel1.Text = "FAT2 WO";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel17
            // 
            this.uiMarkLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel17.Location = new System.Drawing.Point(8, 212);
            this.uiMarkLabel17.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel17.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.uiMarkLabel17.Name = "uiMarkLabel17";
            this.uiMarkLabel17.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.uiMarkLabel17.Size = new System.Drawing.Size(79, 23);
            this.uiMarkLabel17.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel17.TabIndex = 124;
            this.uiMarkLabel17.Text = "FAT3 WO";
            this.uiMarkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(154)))), ((int)(((byte)(213)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(192, 325);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(87, 35);
            this.btnSave.TabIndex = 103;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelImport
            // 
            this.panelImport.Controls.Add(this.rdo_2);
            this.panelImport.Controls.Add(this.rdo_1);
            this.panelImport.Controls.Add(this.rdo_0);
            this.panelImport.Controls.Add(this.btnSave);
            this.panelImport.Controls.Add(this.grouptextbox);
            this.panelImport.Controls.Add(this.uiPanel1);
            this.panelImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImport.Location = new System.Drawing.Point(0, 35);
            this.panelImport.Name = "panelImport";
            this.panelImport.Size = new System.Drawing.Size(450, 369);
            this.panelImport.TabIndex = 130;
            // 
            // rdo_2
            // 
            this.rdo_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdo_2.Location = new System.Drawing.Point(319, 401);
            this.rdo_2.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdo_2.Name = "rdo_2";
            this.rdo_2.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdo_2.Size = new System.Drawing.Size(109, 29);
            this.rdo_2.TabIndex = 143;
            this.rdo_2.Text = "TOKUSAI";
            this.rdo_2.Visible = false;
            // 
            // rdo_1
            // 
            this.rdo_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdo_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdo_1.Location = new System.Drawing.Point(177, 401);
            this.rdo_1.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdo_1.Name = "rdo_1";
            this.rdo_1.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdo_1.Size = new System.Drawing.Size(121, 29);
            this.rdo_1.TabIndex = 143;
            this.rdo_1.Text = "ECO Nội Bộ";
            this.rdo_1.Visible = false;
            // 
            // rdo_0
            // 
            this.rdo_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdo_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdo_0.Location = new System.Drawing.Point(26, 401);
            this.rdo_0.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdo_0.Name = "rdo_0";
            this.rdo_0.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdo_0.Size = new System.Drawing.Size(109, 29);
            this.rdo_0.TabIndex = 143;
            this.rdo_0.Text = "ECN/ECO";
            this.rdo_0.Visible = false;
            // 
            // grouptextbox
            // 
            this.grouptextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.grouptextbox.Controls.Add(this.panel7);
            this.grouptextbox.Controls.Add(this.panel6);
            this.grouptextbox.Controls.Add(this.panel5);
            this.grouptextbox.Controls.Add(this.panel4);
            this.grouptextbox.Controls.Add(this.panel3);
            this.grouptextbox.Controls.Add(this.panel2);
            this.grouptextbox.Controls.Add(this.panel1);
            this.grouptextbox.Controls.Add(this.panelInsertWO);
            this.grouptextbox.Controls.Add(this.txtAIQty);
            this.grouptextbox.Controls.Add(this.lbModelName);
            this.grouptextbox.Controls.Add(this.txtSMTAQty);
            this.grouptextbox.Controls.Add(this.lbNewPart);
            this.grouptextbox.Controls.Add(this.uiMarkLabel16);
            this.grouptextbox.Controls.Add(this.txtSMTBQty);
            this.grouptextbox.Controls.Add(this.txtFAT3Qty);
            this.grouptextbox.Controls.Add(this.uiMarkLabel4);
            this.grouptextbox.Controls.Add(this.txtSMTQty);
            this.grouptextbox.Controls.Add(this.uiMarkLabel5);
            this.grouptextbox.Controls.Add(this.uiMarkLabel11);
            this.grouptextbox.Controls.Add(this.txtFAT2Qty);
            this.grouptextbox.Controls.Add(this.txtFAT1Qty);
            this.grouptextbox.Controls.Add(this.uiMarkLabel2);
            this.grouptextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.grouptextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouptextbox.Location = new System.Drawing.Point(0, 38);
            this.grouptextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouptextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.grouptextbox.Name = "grouptextbox";
            this.grouptextbox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grouptextbox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grouptextbox.Size = new System.Drawing.Size(450, 279);
            this.grouptextbox.TabIndex = 141;
            this.grouptextbox.Text = "Nhập thông tin";
            this.grouptextbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(914, 10);
            this.panel7.TabIndex = 144;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1, 236);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(914, 10);
            this.panel6.TabIndex = 143;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(914, 10);
            this.panel5.TabIndex = 142;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 10);
            this.panel4.TabIndex = 141;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 10);
            this.panel3.TabIndex = 140;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 10);
            this.panel2.TabIndex = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 10);
            this.panel1.TabIndex = 139;
            // 
            // panelInsertWO
            // 
            this.panelInsertWO.Controls.Add(this.txtAI);
            this.panelInsertWO.Controls.Add(this.lbECO);
            this.panelInsertWO.Controls.Add(this.txtSMTA);
            this.panelInsertWO.Controls.Add(this.lbOldPart);
            this.panelInsertWO.Controls.Add(this.txtSMTB);
            this.panelInsertWO.Controls.Add(this.lbContentchange);
            this.panelInsertWO.Controls.Add(this.txtSMT);
            this.panelInsertWO.Controls.Add(this.uiMarkLabel12);
            this.panelInsertWO.Controls.Add(this.uiMarkLabel17);
            this.panelInsertWO.Controls.Add(this.txtFAT1);
            this.panelInsertWO.Controls.Add(this.uiMarkLabel3);
            this.panelInsertWO.Controls.Add(this.uiMarkLabel1);
            this.panelInsertWO.Controls.Add(this.txtFAT3);
            this.panelInsertWO.Controls.Add(this.txtFAT2);
            this.panelInsertWO.Location = new System.Drawing.Point(3, 35);
            this.panelInsertWO.Name = "panelInsertWO";
            this.panelInsertWO.Size = new System.Drawing.Size(249, 241);
            this.panelInsertWO.TabIndex = 103;
            // 
            // txtAI
            // 
            this.txtAI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAI.Location = new System.Drawing.Point(88, 7);
            this.txtAI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAI.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAI.Name = "txtAI";
            this.txtAI.Padding = new System.Windows.Forms.Padding(5);
            this.txtAI.ShowText = false;
            this.txtAI.Size = new System.Drawing.Size(154, 24);
            this.txtAI.Symbol = 57397;
            this.txtAI.TabIndex = 8;
            this.txtAI.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAI.Watermark = "";
            this.txtAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMTA
            // 
            this.txtSMTA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMTA.Location = new System.Drawing.Point(88, 41);
            this.txtSMTA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMTA.Maximum = 10D;
            this.txtSMTA.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMTA.Name = "txtSMTA";
            this.txtSMTA.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMTA.ShowText = false;
            this.txtSMTA.Size = new System.Drawing.Size(154, 24);
            this.txtSMTA.Symbol = 61573;
            this.txtSMTA.TabIndex = 130;
            this.txtSMTA.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMTA.Watermark = "";
            this.txtSMTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMTB
            // 
            this.txtSMTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMTB.Location = new System.Drawing.Point(88, 75);
            this.txtSMTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMTB.Maximum = 10D;
            this.txtSMTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMTB.Name = "txtSMTB";
            this.txtSMTB.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMTB.ShowText = false;
            this.txtSMTB.Size = new System.Drawing.Size(154, 24);
            this.txtSMTB.Symbol = 61573;
            this.txtSMTB.TabIndex = 6;
            this.txtSMTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMTB.Watermark = "";
            this.txtSMTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMT
            // 
            this.txtSMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMT.Location = new System.Drawing.Point(88, 109);
            this.txtSMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMT.Maximum = 10D;
            this.txtSMT.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMT.Name = "txtSMT";
            this.txtSMT.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMT.ShowText = false;
            this.txtSMT.Size = new System.Drawing.Size(154, 24);
            this.txtSMT.Symbol = 61573;
            this.txtSMT.TabIndex = 6;
            this.txtSMT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMT.Watermark = "";
            this.txtSMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT1
            // 
            this.txtFAT1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT1.Location = new System.Drawing.Point(88, 143);
            this.txtFAT1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT1.Maximum = 10D;
            this.txtFAT1.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT1.Name = "txtFAT1";
            this.txtFAT1.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT1.ShowText = false;
            this.txtFAT1.Size = new System.Drawing.Size(154, 24);
            this.txtFAT1.Symbol = 61613;
            this.txtFAT1.TabIndex = 134;
            this.txtFAT1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT1.Watermark = "";
            this.txtFAT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT3
            // 
            this.txtFAT3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT3.Location = new System.Drawing.Point(88, 211);
            this.txtFAT3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT3.Maximum = 10D;
            this.txtFAT3.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT3.Name = "txtFAT3";
            this.txtFAT3.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT3.ShowText = false;
            this.txtFAT3.Size = new System.Drawing.Size(154, 24);
            this.txtFAT3.Symbol = 61613;
            this.txtFAT3.TabIndex = 137;
            this.txtFAT3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT3.Watermark = "";
            this.txtFAT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT2
            // 
            this.txtFAT2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT2.Location = new System.Drawing.Point(88, 177);
            this.txtFAT2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT2.Maximum = 10D;
            this.txtFAT2.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT2.Name = "txtFAT2";
            this.txtFAT2.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT2.ShowText = false;
            this.txtFAT2.Size = new System.Drawing.Size(154, 24);
            this.txtFAT2.Symbol = 61613;
            this.txtFAT2.TabIndex = 136;
            this.txtFAT2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT2.Watermark = "";
            this.txtFAT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtAIQty
            // 
            this.txtAIQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAIQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAIQty.Location = new System.Drawing.Point(338, 42);
            this.txtAIQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAIQty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAIQty.Name = "txtAIQty";
            this.txtAIQty.Padding = new System.Windows.Forms.Padding(5);
            this.txtAIQty.ShowText = false;
            this.txtAIQty.Size = new System.Drawing.Size(106, 24);
            this.txtAIQty.TabIndex = 7;
            this.txtAIQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAIQty.Watermark = "";
            this.txtAIQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMTAQty
            // 
            this.txtSMTAQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTAQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMTAQty.Location = new System.Drawing.Point(338, 76);
            this.txtSMTAQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMTAQty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMTAQty.Name = "txtSMTAQty";
            this.txtSMTAQty.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMTAQty.ShowText = false;
            this.txtSMTAQty.Size = new System.Drawing.Size(106, 24);
            this.txtSMTAQty.TabIndex = 131;
            this.txtSMTAQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMTAQty.Watermark = "";
            this.txtSMTAQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMTBQty
            // 
            this.txtSMTBQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTBQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMTBQty.Location = new System.Drawing.Point(338, 110);
            this.txtSMTBQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMTBQty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMTBQty.Name = "txtSMTBQty";
            this.txtSMTBQty.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMTBQty.ShowText = false;
            this.txtSMTBQty.Size = new System.Drawing.Size(106, 24);
            this.txtSMTBQty.TabIndex = 6;
            this.txtSMTBQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMTBQty.Watermark = "";
            this.txtSMTBQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT3Qty
            // 
            this.txtFAT3Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT3Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT3Qty.Location = new System.Drawing.Point(338, 246);
            this.txtFAT3Qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT3Qty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT3Qty.Name = "txtFAT3Qty";
            this.txtFAT3Qty.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT3Qty.ShowText = false;
            this.txtFAT3Qty.Size = new System.Drawing.Size(106, 24);
            this.txtFAT3Qty.TabIndex = 135;
            this.txtFAT3Qty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT3Qty.Watermark = "";
            this.txtFAT3Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtSMTQty
            // 
            this.txtSMTQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSMTQty.Location = new System.Drawing.Point(338, 144);
            this.txtSMTQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSMTQty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSMTQty.Name = "txtSMTQty";
            this.txtSMTQty.Padding = new System.Windows.Forms.Padding(5);
            this.txtSMTQty.ShowText = false;
            this.txtSMTQty.Size = new System.Drawing.Size(106, 24);
            this.txtSMTQty.TabIndex = 6;
            this.txtSMTQty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSMTQty.Watermark = "";
            this.txtSMTQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT2Qty
            // 
            this.txtFAT2Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT2Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT2Qty.Location = new System.Drawing.Point(338, 212);
            this.txtFAT2Qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT2Qty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT2Qty.Name = "txtFAT2Qty";
            this.txtFAT2Qty.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT2Qty.ShowText = false;
            this.txtFAT2Qty.Size = new System.Drawing.Size(106, 24);
            this.txtFAT2Qty.TabIndex = 138;
            this.txtFAT2Qty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT2Qty.Watermark = "";
            this.txtFAT2Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtFAT1Qty
            // 
            this.txtFAT1Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFAT1Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFAT1Qty.Location = new System.Drawing.Point(338, 178);
            this.txtFAT1Qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFAT1Qty.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFAT1Qty.Name = "txtFAT1Qty";
            this.txtFAT1Qty.Padding = new System.Windows.Forms.Padding(5);
            this.txtFAT1Qty.ShowText = false;
            this.txtFAT1Qty.Size = new System.Drawing.Size(106, 24);
            this.txtFAT1Qty.TabIndex = 133;
            this.txtFAT1Qty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFAT1Qty.Watermark = "";
            this.txtFAT1Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.txtWOpending);
            this.uiPanel1.Controls.Add(this.btnClear);
            this.uiPanel1.Controls.Add(this.btnImport);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiPanel1.Size = new System.Drawing.Size(450, 38);
            this.uiPanel1.TabIndex = 142;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(197, 8);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 23);
            this.uiLabel1.TabIndex = 145;
            this.uiLabel1.Text = "Pending:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWOpending
            // 
            this.txtWOpending.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWOpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWOpending.Location = new System.Drawing.Point(272, 2);
            this.txtWOpending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWOpending.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtWOpending.Name = "txtWOpending";
            this.txtWOpending.Padding = new System.Windows.Forms.Padding(5);
            this.txtWOpending.ShowText = false;
            this.txtWOpending.Size = new System.Drawing.Size(172, 32);
            this.txtWOpending.TabIndex = 103;
            this.txtWOpending.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtWOpending.Watermark = "";
            // 
            // FormInsertWO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 404);
            this.Controls.Add(this.panelImport);
            this.Name = "FormInsertWO";
            this.Text = "FormInsertWO";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 944, 746);
            this.Load += new System.EventHandler(this.FormInsertWO_Load);
            this.panelImport.ResumeLayout(false);
            this.grouptextbox.ResumeLayout(false);
            this.panelInsertWO.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private Sunny.UI.UISymbolButton btnImport;
        private Sunny.UI.UIMarkLabel lbModelName;
        private Sunny.UI.UIMarkLabel lbNewPart;
        private Sunny.UI.UIMarkLabel lbECO;
        private Sunny.UI.UIMarkLabel uiMarkLabel4;
        private Sunny.UI.UIMarkLabel uiMarkLabel11;
        private Sunny.UI.UIMarkLabel lbOldPart;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel lbContentchange;
        private Sunny.UI.UIMarkLabel uiMarkLabel5;
        private Sunny.UI.UIMarkLabel uiMarkLabel12;
        private Sunny.UI.UIMarkLabel uiMarkLabel16;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel17;
        private Sunny.UI.UISymbolButton btnSave;
        private System.Windows.Forms.Panel panelImport;
        private Sunny.UI.UITextBox txtFAT3;
        private Sunny.UI.UITextBox txtFAT2;
        private Sunny.UI.UITextBox txtFAT3Qty;
        private Sunny.UI.UITextBox txtFAT1;
        private Sunny.UI.UITextBox txtFAT2Qty;
        private Sunny.UI.UITextBox txtSMT;
        private Sunny.UI.UITextBox txtFAT1Qty;
        private Sunny.UI.UITextBox txtSMTB;
        private Sunny.UI.UITextBox txtSMTQty;
        private Sunny.UI.UITextBox txtSMTBQty;
        private Sunny.UI.UITextBox txtSMTA;
        private Sunny.UI.UITextBox txtSMTAQty;
        private Sunny.UI.UITextBox txtAI;
        private Sunny.UI.UITextBox txtAIQty;
        private Sunny.UI.UIGroupBox grouptextbox;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIRadioButton rdo_2;
        private Sunny.UI.UIRadioButton rdo_1;
        private Sunny.UI.UIRadioButton rdo_0;
        private System.Windows.Forms.Panel panelInsertWO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private Sunny.UI.UITextBox txtWOpending;
        private Sunny.UI.UILabel uiLabel1;
    }
}