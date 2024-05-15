namespace _22520853_Lab03
{
    partial class Bai1_Client
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tb_IP_Host = new TextBox();
            tb_Port = new TextBox();
            rtb_Message = new RichTextBox();
            btn_Send = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tb_IP_Host
            // 
            tb_IP_Host.Location = new Point(92, 67);
            tb_IP_Host.Name = "tb_IP_Host";
            tb_IP_Host.Size = new Size(234, 27);
            tb_IP_Host.TabIndex = 1;
            tb_IP_Host.TextChanged += tb_IP_Host_TextChanged;
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(476, 67);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(98, 27);
            tb_Port.TabIndex = 2;
            // 
            // rtb_Message
            // 
            rtb_Message.BackColor = SystemColors.Info;
            rtb_Message.Location = new Point(92, 160);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(482, 255);
            rtb_Message.TabIndex = 3;
            rtb_Message.Text = "";
            // 
            // btn_Send
            // 
            btn_Send.BackColor = SystemColors.ActiveCaption;
            btn_Send.Location = new Point(480, 115);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(94, 29);
            btn_Send.TabIndex = 4;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 44);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 44);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 137);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Message";
            // 
            // Bai1_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Send);
            Controls.Add(rtb_Message);
            Controls.Add(tb_Port);
            Controls.Add(tb_IP_Host);
            Name = "Bai1_Client";
            Text = "Bai1_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox tb_IP_Host;
        private TextBox tb_Port;
        private RichTextBox rtb_Message;
        private Button btn_Send;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}