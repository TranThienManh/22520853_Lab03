namespace _22520853_Lab03
{
    partial class Bai2
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
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(507, 31);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(94, 29);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_ShowMessage
            // 
            rtb_ShowMessage.Location = new Point(38, 66);
            rtb_ShowMessage.Name = "rtb_ShowMessage";
            rtb_ShowMessage.ReadOnly = true;
            rtb_ShowMessage.Size = new Size(563, 283);
            rtb_ShowMessage.TabIndex = 1;
            rtb_ShowMessage.Text = "";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(390, 31);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 398);
            Controls.Add(btn_Exit);
            Controls.Add(rtb_ShowMessage);
            Controls.Add(btn_Listen);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private RichTextBox rtb_ShowMessage;
        private Button btn_Exit;
    }
}