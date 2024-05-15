namespace _22520853_Lab03
{
    partial class Bai1_Server
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
            tb_PortListen = new TextBox();
            btn_Listen = new Button();
            rtb_RMessage = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tb_PortListen
            // 
            tb_PortListen.Location = new Point(42, 59);
            tb_PortListen.Name = "tb_PortListen";
            tb_PortListen.Size = new Size(117, 27);
            tb_PortListen.TabIndex = 0;
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(353, 59);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(94, 29);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_RMessage
            // 
            rtb_RMessage.BackColor = SystemColors.Info;
            rtb_RMessage.Location = new Point(42, 139);
            rtb_RMessage.Name = "rtb_RMessage";
            rtb_RMessage.Size = new Size(405, 257);
            rtb_RMessage.TabIndex = 2;
            rtb_RMessage.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 36);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 116);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 4;
            label2.Text = "Received Message";
            // 
            // Bai1_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 448);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_RMessage);
            Controls.Add(btn_Listen);
            Controls.Add(tb_PortListen);
            Name = "Bai1_Server";
            Text = "Bai1_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_PortListen;
        private Button btn_Listen;
        private RichTextBox rtb_RMessage;
        private Label label1;
        private Label label2;
    }
}