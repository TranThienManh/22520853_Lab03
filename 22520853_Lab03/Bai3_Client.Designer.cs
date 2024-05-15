namespace _22520853_Lab03
{
    partial class Bai3_Client
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
            btn_Connect = new Button();
            btn_Send = new Button();
            btn_DisConnect = new Button();
            rtb_Message = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(443, 50);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(94, 29);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(443, 102);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(94, 29);
            btn_Send.TabIndex = 1;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_DisConnect
            // 
            btn_DisConnect.Location = new Point(443, 153);
            btn_DisConnect.Name = "btn_DisConnect";
            btn_DisConnect.Size = new Size(94, 29);
            btn_DisConnect.TabIndex = 2;
            btn_DisConnect.Text = "Disconnect";
            btn_DisConnect.UseVisualStyleBackColor = true;
            btn_DisConnect.Click += btn_DisConnect_Click;
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(54, 51);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(383, 214);
            rtb_Message.TabIndex = 3;
            rtb_Message.Text = "";
            // 
            // Bai3_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_Message);
            Controls.Add(btn_DisConnect);
            Controls.Add(btn_Send);
            Controls.Add(btn_Connect);
            Name = "Bai3_Client";
            Text = "Bai3_Client";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Connect;
        private Button btn_Send;
        private Button btn_DisConnect;
        private RichTextBox rtb_Message;
    }
}