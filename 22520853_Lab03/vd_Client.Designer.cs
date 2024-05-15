namespace _22520853_Lab03
{
    partial class vd_Client
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
            IP = new TextBox();
            btn_Send = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // IP
            // 
            IP.BackColor = SystemColors.ButtonHighlight;
            IP.Location = new Point(125, 9);
            IP.Name = "IP";
            IP.ReadOnly = true;
            IP.Size = new Size(287, 27);
            IP.TabIndex = 0;
            IP.Text = "127.0.0.1";
            IP.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = SystemColors.ButtonHighlight;
            btn_Send.Location = new Point(209, 51);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(111, 26);
            btn_Send.TabIndex = 1;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Remote Host:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Send);
            panel1.Controls.Add(IP);
            panel1.Location = new Point(32, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 98);
            panel1.TabIndex = 3;
            // 
            // vd_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 203);
            Controls.Add(panel1);
            Name = "vd_Client";
            Text = "vd_Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox IP;
        private Button btn_Send;
        private Label label1;
        private Panel panel1;
    }
}