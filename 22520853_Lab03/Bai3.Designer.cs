﻿namespace _22520853_Lab03
{
    partial class Bai3
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
            btn_Server = new Button();
            btn_Client = new Button();
            SuspendLayout();
            // 
            // btn_Server
            // 
            btn_Server.Location = new Point(98, 74);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(115, 53);
            btn_Server.TabIndex = 0;
            btn_Server.Text = "Server";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // btn_Client
            // 
            btn_Client.Location = new Point(264, 74);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(115, 53);
            btn_Client.TabIndex = 1;
            btn_Client.Text = "Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 195);
            Controls.Add(btn_Client);
            Controls.Add(btn_Server);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Server;
        private Button btn_Client;
    }
}