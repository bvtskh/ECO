
namespace ECO_DX_For_PUR.GUI
{
    partial class FormInsertECOSchedule
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImport = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.panelImport = new System.Windows.Forms.Panel();
            this.grouptextbox = new Sunny.UI.UIGroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.switchStartApproveDate = new Sunny.UI.UISwitch();
            this.switchReceiveDate = new Sunny.UI.UISwitch();
            this.txtContentChange = new Sunny.UI.UITextBox();
            this.startApproveDate = new Sunny.UI.UIDatePicker();
            this.receiveDate = new Sunny.UI.UIDatePicker();
            this.lbECO = new Sunny.UI.UIMarkLabel();
            this.txtModel = new Sunny.UI.UITextBox();
            this.lbOldPart = new Sunny.UI.UIMarkLabel();
            this.txtECO = new Sunny.UI.UITextBox();
            this.txtECN = new Sunny.UI.UITextBox();
            this.uiMarkLabel12 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.switchImplementDate = new Sunny.UI.UISwitch();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.implement_date = new Sunny.UI.UIDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new Sunny.UI.UITextBox();
            this.uiPanel1.SuspendLayout();
            this.panelImport.SuspendLayout();
            this.grouptextbox.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.lblTitle);
            this.uiPanel1.Controls.Add(this.btnClear);
            this.uiPanel1.Controls.Add(this.btnImport);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiPanel1.Size = new System.Drawing.Size(692, 38);
            this.uiPanel1.TabIndex = 142;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(342, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 24);
            this.lblTitle.TabIndex = 103;
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
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(214)))), ((int)(((byte)(123)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::ECO_DX_For_PUR.GUI.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(250, 263);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(192, 35);
            this.btnSave.Symbol = 61639;
            this.btnSave.TabIndex = 103;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelImport
            // 
            this.panelImport.Controls.Add(this.grouptextbox);
            this.panelImport.Controls.Add(this.uiPanel1);
            this.panelImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImport.Location = new System.Drawing.Point(0, 35);
            this.panelImport.Name = "panelImport";
            this.panelImport.Size = new System.Drawing.Size(692, 401);
            this.panelImport.TabIndex = 131;
            // 
            // grouptextbox
            // 
            this.grouptextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.grouptextbox.Controls.Add(this.panel7);
            this.grouptextbox.Controls.Add(this.panel1);
            this.grouptextbox.Controls.Add(this.panelInsert);
            this.grouptextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.grouptextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouptextbox.Location = new System.Drawing.Point(0, 38);
            this.grouptextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grouptextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.grouptextbox.Name = "grouptextbox";
            this.grouptextbox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grouptextbox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grouptextbox.Size = new System.Drawing.Size(692, 356);
            this.grouptextbox.TabIndex = 141;
            this.grouptextbox.Text = "Nhập thông tin";
            this.grouptextbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(914, 10);
            this.panel7.TabIndex = 144;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 10);
            this.panel1.TabIndex = 139;
            // 
            // panelInsert
            // 
            this.panelInsert.Controls.Add(this.label2);
            this.panelInsert.Controls.Add(this.txtRemark);
            this.panelInsert.Controls.Add(this.label1);
            this.panelInsert.Controls.Add(this.txtContentChange);
            this.panelInsert.Controls.Add(this.implement_date);
            this.panelInsert.Controls.Add(this.switchImplementDate);
            this.panelInsert.Controls.Add(this.switchStartApproveDate);
            this.panelInsert.Controls.Add(this.uiMarkLabel2);
            this.panelInsert.Controls.Add(this.switchReceiveDate);
            this.panelInsert.Controls.Add(this.btnSave);
            this.panelInsert.Controls.Add(this.startApproveDate);
            this.panelInsert.Controls.Add(this.receiveDate);
            this.panelInsert.Controls.Add(this.lbECO);
            this.panelInsert.Controls.Add(this.txtModel);
            this.panelInsert.Controls.Add(this.lbOldPart);
            this.panelInsert.Controls.Add(this.txtECO);
            this.panelInsert.Controls.Add(this.txtECN);
            this.panelInsert.Controls.Add(this.uiMarkLabel12);
            this.panelInsert.Controls.Add(this.uiMarkLabel3);
            this.panelInsert.Controls.Add(this.uiMarkLabel1);
            this.panelInsert.Location = new System.Drawing.Point(3, 34);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(686, 310);
            this.panelInsert.TabIndex = 103;
            // 
            // switchStartApproveDate
            // 
            this.switchStartApproveDate.Active = true;
            this.switchStartApproveDate.ActiveText = "";
            this.switchStartApproveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.switchStartApproveDate.InActiveText = "";
            this.switchStartApproveDate.Location = new System.Drawing.Point(626, 30);
            this.switchStartApproveDate.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchStartApproveDate.Name = "switchStartApproveDate";
            this.switchStartApproveDate.Size = new System.Drawing.Size(55, 29);
            this.switchStartApproveDate.TabIndex = 104;
            this.switchStartApproveDate.Text = "uiSwitch1";
            this.switchStartApproveDate.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch_ValueChanged);
            // 
            // switchReceiveDate
            // 
            this.switchReceiveDate.Active = true;
            this.switchReceiveDate.ActiveText = "";
            this.switchReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.switchReceiveDate.InActiveText = "";
            this.switchReceiveDate.Location = new System.Drawing.Point(176, 30);
            this.switchReceiveDate.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchReceiveDate.Name = "switchReceiveDate";
            this.switchReceiveDate.Size = new System.Drawing.Size(55, 29);
            this.switchReceiveDate.TabIndex = 104;
            this.switchReceiveDate.Text = "uiSwitch1";
            this.switchReceiveDate.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch_ValueChanged);
            // 
            // txtContentChange
            // 
            this.txtContentChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContentChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContentChange.Location = new System.Drawing.Point(13, 106);
            this.txtContentChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContentChange.Maximum = 10D;
            this.txtContentChange.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtContentChange.Name = "txtContentChange";
            this.txtContentChange.Padding = new System.Windows.Forms.Padding(5);
            this.txtContentChange.ShowText = false;
            this.txtContentChange.Size = new System.Drawing.Size(669, 28);
            this.txtContentChange.Symbol = 61601;
            this.txtContentChange.TabIndex = 146;
            this.txtContentChange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtContentChange.Watermark = "";
            // 
            // startApproveDate
            // 
            this.startApproveDate.FillColor = System.Drawing.Color.White;
            this.startApproveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startApproveDate.Location = new System.Drawing.Point(462, 30);
            this.startApproveDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startApproveDate.MaxLength = 10;
            this.startApproveDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.startApproveDate.Name = "startApproveDate";
            this.startApproveDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.startApproveDate.Size = new System.Drawing.Size(157, 29);
            this.startApproveDate.SymbolDropDown = 61555;
            this.startApproveDate.SymbolNormal = 61555;
            this.startApproveDate.TabIndex = 145;
            this.startApproveDate.Text = "2024-01-29";
            this.startApproveDate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.startApproveDate.Value = new System.DateTime(2024, 1, 29, 11, 10, 58, 460);
            this.startApproveDate.Watermark = "";
            // 
            // receiveDate
            // 
            this.receiveDate.FillColor = System.Drawing.Color.White;
            this.receiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.receiveDate.Location = new System.Drawing.Point(12, 30);
            this.receiveDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receiveDate.MaxLength = 10;
            this.receiveDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.receiveDate.Name = "receiveDate";
            this.receiveDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.receiveDate.Size = new System.Drawing.Size(157, 29);
            this.receiveDate.SymbolDropDown = 61555;
            this.receiveDate.SymbolNormal = 61555;
            this.receiveDate.TabIndex = 145;
            this.receiveDate.Text = "2024-01-29";
            this.receiveDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.receiveDate.Value = new System.DateTime(2024, 1, 29, 11, 10, 58, 460);
            this.receiveDate.Watermark = "";
            // 
            // lbECO
            // 
            this.lbECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbECO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbECO.Location = new System.Drawing.Point(31, 6);
            this.lbECO.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbECO.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbECO.Name = "lbECO";
            this.lbECO.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbECO.Size = new System.Drawing.Size(131, 28);
            this.lbECO.Style = Sunny.UI.UIStyle.Custom;
            this.lbECO.TabIndex = 86;
            this.lbECO.Text = "Ngày nhận tài liệu";
            this.lbECO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModel
            // 
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtModel.Location = new System.Drawing.Point(12, 166);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Maximum = 10D;
            this.txtModel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(5);
            this.txtModel.ShowText = false;
            this.txtModel.Size = new System.Drawing.Size(194, 28);
            this.txtModel.Symbol = 62171;
            this.txtModel.TabIndex = 130;
            this.txtModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModel.Watermark = "";
            // 
            // lbOldPart
            // 
            this.lbOldPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbOldPart.Location = new System.Drawing.Point(24, 140);
            this.lbOldPart.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.lbOldPart.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbOldPart.Name = "lbOldPart";
            this.lbOldPart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbOldPart.Size = new System.Drawing.Size(144, 29);
            this.lbOldPart.Style = Sunny.UI.UIStyle.Custom;
            this.lbOldPart.TabIndex = 88;
            this.lbOldPart.Text = "Model";
            this.lbOldPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtECO
            // 
            this.txtECO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtECO.Location = new System.Drawing.Point(487, 166);
            this.txtECO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtECO.Maximum = 10D;
            this.txtECO.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtECO.Name = "txtECO";
            this.txtECO.Padding = new System.Windows.Forms.Padding(5);
            this.txtECO.ShowText = false;
            this.txtECO.Size = new System.Drawing.Size(194, 28);
            this.txtECO.Symbol = 361874;
            this.txtECO.TabIndex = 6;
            this.txtECO.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtECO.Watermark = "";
            // 
            // txtECN
            // 
            this.txtECN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtECN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtECN.Location = new System.Drawing.Point(252, 166);
            this.txtECN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtECN.Maximum = 10D;
            this.txtECN.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtECN.Name = "txtECN";
            this.txtECN.Padding = new System.Windows.Forms.Padding(5);
            this.txtECN.ShowText = false;
            this.txtECN.Size = new System.Drawing.Size(192, 28);
            this.txtECN.Symbol = 361875;
            this.txtECN.TabIndex = 6;
            this.txtECN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtECN.Watermark = "";
            // 
            // uiMarkLabel12
            // 
            this.uiMarkLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel12.Location = new System.Drawing.Point(283, 139);
            this.uiMarkLabel12.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel12.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel12.Name = "uiMarkLabel12";
            this.uiMarkLabel12.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel12.Size = new System.Drawing.Size(138, 31);
            this.uiMarkLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel12.TabIndex = 113;
            this.uiMarkLabel12.Text = "ECN/DCI No";
            this.uiMarkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel3.Location = new System.Drawing.Point(467, 7);
            this.uiMarkLabel3.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel3.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel3.Size = new System.Drawing.Size(148, 27);
            this.uiMarkLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel3.TabIndex = 96;
            this.uiMarkLabel3.Text = "Ngày bắt đầu áp dụng";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel1.Location = new System.Drawing.Point(502, 142);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel1.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(136, 28);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 98;
            this.uiMarkLabel1.Text = "UMC ECO NO";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchImplementDate
            // 
            this.switchImplementDate.Active = true;
            this.switchImplementDate.ActiveText = "";
            this.switchImplementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.switchImplementDate.InActiveText = "";
            this.switchImplementDate.Location = new System.Drawing.Point(402, 30);
            this.switchImplementDate.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchImplementDate.Name = "switchImplementDate";
            this.switchImplementDate.Size = new System.Drawing.Size(55, 29);
            this.switchImplementDate.TabIndex = 147;
            this.switchImplementDate.Text = "uiSwitch1";
            this.switchImplementDate.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitch_ValueChanged);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiMarkLabel2.Location = new System.Drawing.Point(243, 8);
            this.uiMarkLabel2.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiMarkLabel2.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel2.Size = new System.Drawing.Size(148, 27);
            this.uiMarkLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 146;
            this.uiMarkLabel2.Text = "Ngày triển khai";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // implement_date
            // 
            this.implement_date.FillColor = System.Drawing.Color.White;
            this.implement_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.implement_date.Location = new System.Drawing.Point(238, 30);
            this.implement_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.implement_date.MaxLength = 10;
            this.implement_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.implement_date.Name = "implement_date";
            this.implement_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.implement_date.Size = new System.Drawing.Size(157, 29);
            this.implement_date.SymbolDropDown = 61555;
            this.implement_date.SymbolNormal = 61555;
            this.implement_date.TabIndex = 148;
            this.implement_date.Text = "2024-01-29";
            this.implement_date.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.implement_date.Value = new System.DateTime(2024, 1, 29, 11, 10, 58, 460);
            this.implement_date.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Nội dung thay đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 151;
            this.label2.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRemark.Location = new System.Drawing.Point(13, 227);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemark.Maximum = 10D;
            this.txtRemark.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Padding = new System.Windows.Forms.Padding(5);
            this.txtRemark.ShowText = false;
            this.txtRemark.Size = new System.Drawing.Size(669, 28);
            this.txtRemark.Symbol = 61601;
            this.txtRemark.TabIndex = 150;
            this.txtRemark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRemark.Watermark = "";
            // 
            // FormInsertECOSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(692, 436);
            this.Controls.Add(this.panelImport);
            this.Name = "FormInsertECOSchedule";
            this.Text = "FormInsertECOSchedule";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 399, 344);
            this.Load += new System.EventHandler(this.FormInsertECOSchedule_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.panelImport.ResumeLayout(false);
            this.grouptextbox.ResumeLayout(false);
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Button btnClear;
        private Sunny.UI.UISymbolButton btnImport;
        private Sunny.UI.UISymbolButton btnSave;
        private System.Windows.Forms.Panel panelImport;
        private Sunny.UI.UIGroupBox grouptextbox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInsert;
        private Sunny.UI.UIDatePicker startApproveDate;
        private Sunny.UI.UIDatePicker receiveDate;
        private Sunny.UI.UIMarkLabel lbECO;
        private Sunny.UI.UITextBox txtModel;
        private Sunny.UI.UIMarkLabel lbOldPart;
        private Sunny.UI.UITextBox txtECN;
        private Sunny.UI.UIMarkLabel uiMarkLabel12;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UITextBox txtECO;
        private Sunny.UI.UITextBox txtContentChange;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UISwitch switchStartApproveDate;
        private Sunny.UI.UISwitch switchReceiveDate;
        private Sunny.UI.UIDatePicker implement_date;
        private Sunny.UI.UISwitch switchImplementDate;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtRemark;
        private System.Windows.Forms.Label label1;
    }
}