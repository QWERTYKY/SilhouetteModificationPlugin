﻿namespace Plugin
{
    partial class VersionInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.lblVersionCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "シルエット改変プラグイン";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "バージョン：β";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "作者：QWERTY";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTwitter.ForeColor = System.Drawing.Color.Blue;
            this.lblTwitter.Location = new System.Drawing.Point(101, 65);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(81, 12);
            this.lblTwitter.TabIndex = 1;
            this.lblTwitter.Text = "（QWERTY_KY）";
            this.lblTwitter.Click += new System.EventHandler(this.lblTwitter_Click);
            // 
            // lblVersionCheck
            // 
            this.lblVersionCheck.AutoSize = true;
            this.lblVersionCheck.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVersionCheck.ForeColor = System.Drawing.Color.Blue;
            this.lblVersionCheck.Location = new System.Drawing.Point(101, 44);
            this.lblVersionCheck.Name = "lblVersionCheck";
            this.lblVersionCheck.Size = new System.Drawing.Size(81, 12);
            this.lblVersionCheck.TabIndex = 1;
            this.lblVersionCheck.Text = "最新を確認する";
            this.lblVersionCheck.Click += new System.EventHandler(this.lblVersionCheck_Click);
            // 
            // VersionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 86);
            this.Controls.Add(this.lblVersionCheck);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionInfo";
            this.Text = "バージョン情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.Label lblVersionCheck;
    }
}