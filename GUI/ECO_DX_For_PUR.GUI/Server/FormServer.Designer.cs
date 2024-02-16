
namespace Server
{
    partial class FormServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btncon = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtsv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(346, 354);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 31);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btncon
            // 
            this.btncon.Location = new System.Drawing.Point(433, 354);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(81, 31);
            this.btncon.TabIndex = 8;
            this.btncon.Text = "Connect";
            this.btncon.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(128, 45);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(386, 274);
            this.txtChat.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(128, 325);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(386, 23);
            this.txtMessage.TabIndex = 5;
            // 
            // txtsv
            // 
            this.txtsv.Location = new System.Drawing.Point(128, 16);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(386, 23);
            this.txtsv.TabIndex = 6;
            this.txtsv.Text = "172.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "client";
            // 
            // lblIP
            // 
            this.lblIP.FormattingEnabled = true;
            this.lblIP.ItemHeight = 15;
            this.lblIP.Location = new System.Drawing.Point(529, 45);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(230, 304);
            this.lblIP.TabIndex = 11;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtsv);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lblIP;
    }
}

