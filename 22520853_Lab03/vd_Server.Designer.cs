namespace _22520853_Lab03
{
    partial class vd_Server
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
            lst_Mess = new ListView();
            SuspendLayout();
            // 
            // lst_Mess
            // 
            lst_Mess.Location = new Point(38, 32);
            lst_Mess.Name = "lst_Mess";
            lst_Mess.Size = new Size(455, 263);
            lst_Mess.TabIndex = 0;
            lst_Mess.UseCompatibleStateImageBehavior = false;
            lst_Mess.View = View.List;
            // 
            // vd_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 332);
            Controls.Add(lst_Mess);
            Name = "vd_Server";
            Text = "vd_Server";
            Load += vd_Server_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lst_Mess;
    }
}