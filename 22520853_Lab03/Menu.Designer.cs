namespace _22520853_Lab03
{
    partial class Menu
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
            btn_VD = new Button();
            btn_Bai01 = new Button();
            btn_Bai2 = new Button();
            btn_Bai3 = new Button();
            btn_Bai6 = new Button();
            SuspendLayout();
            // 
            // btn_VD
            // 
            btn_VD.Location = new Point(74, 48);
            btn_VD.Name = "btn_VD";
            btn_VD.Size = new Size(94, 29);
            btn_VD.TabIndex = 0;
            btn_VD.Text = "VD";
            btn_VD.UseVisualStyleBackColor = true;
            btn_VD.Click += btn_VD_Click;
            // 
            // btn_Bai01
            // 
            btn_Bai01.Location = new Point(74, 103);
            btn_Bai01.Name = "btn_Bai01";
            btn_Bai01.Size = new Size(94, 37);
            btn_Bai01.TabIndex = 1;
            btn_Bai01.Text = "Bài 01";
            btn_Bai01.UseVisualStyleBackColor = true;
            btn_Bai01.Click += btn_Bai01_Click;
            // 
            // btn_Bai2
            // 
            btn_Bai2.Location = new Point(74, 164);
            btn_Bai2.Name = "btn_Bai2";
            btn_Bai2.Size = new Size(94, 37);
            btn_Bai2.TabIndex = 2;
            btn_Bai2.Text = "Bài 02";
            btn_Bai2.UseVisualStyleBackColor = true;
            btn_Bai2.Click += btn_Bai2_Click;
            // 
            // btn_Bai3
            // 
            btn_Bai3.Location = new Point(74, 224);
            btn_Bai3.Name = "btn_Bai3";
            btn_Bai3.Size = new Size(94, 37);
            btn_Bai3.TabIndex = 3;
            btn_Bai3.Text = "Bài 03";
            btn_Bai3.UseVisualStyleBackColor = true;
            btn_Bai3.Click += btn_Bai3_Click;
            // 
            // btn_Bai6
            // 
            btn_Bai6.Location = new Point(74, 283);
            btn_Bai6.Name = "btn_Bai6";
            btn_Bai6.Size = new Size(94, 37);
            btn_Bai6.TabIndex = 4;
            btn_Bai6.Text = "Bài 06";
            btn_Bai6.UseVisualStyleBackColor = true;
            btn_Bai6.Click += btn_Bai6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 375);
            Controls.Add(btn_Bai6);
            Controls.Add(btn_Bai3);
            Controls.Add(btn_Bai2);
            Controls.Add(btn_Bai01);
            Controls.Add(btn_VD);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_VD;
        private Button btn_Bai01;
        private Button btn_Bai2;
        private Button btn_Bai3;
        private Button btn_Bai6;
    }
}
