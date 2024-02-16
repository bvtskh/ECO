
namespace Client
{
    partial class FormClient
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
            this.txtsv = new System.Windows.Forms.TextBox();
            this.btncon = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsv
            // 
            this.txtsv.Location = new System.Drawing.Point(141, 44);
            this.txtsv.Name = "txtsv";
            this.txtsv.Size = new System.Drawing.Size(410, 23);
            this.txtsv.TabIndex = 0;
            this.txtsv.Text = "172.0.0.1:9000";
            // 
            // btncon
            // 
            this.btncon.Location = new System.Drawing.Point(381, 389);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(81, 31);
            this.btncon.TabIndex = 2;
            this.btncon.Text = "Connect";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(470, 389);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(141, 73);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(410, 274);
            this.txtChat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(141, 353);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(410, 23);
            this.txtMessage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtsv);
            this.Name = "FormClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
    }
}

