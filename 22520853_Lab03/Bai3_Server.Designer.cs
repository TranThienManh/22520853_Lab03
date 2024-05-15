namespace _22520853_Lab03
{
    partial class Bai3_Server
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
            btn_Listen = new Button();
            rtb_ShowMessage = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(451, 21);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(94, 29);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_ShowMessage
            // 
            rtb_ShowMessage.Location = new Point(54, 70);
            rtb_ShowMessage.Name = "rtb_ShowMessage";
            rtb_ShowMessage.Size = new Size(491, 293);
            rtb_ShowMessage.TabIndex = 1;
            rtb_ShowMessage.Text = "";
            // 
            // Bai3_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 394);
            Controls.Add(rtb_ShowMessage);
            Controls.Add(btn_Listen);
            Name = "Bai3_Server";
            Text = "Bai3_Server";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private RichTextBox rtb_ShowMessage;
    }
}