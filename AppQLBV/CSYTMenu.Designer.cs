﻿
namespace AppQLBV
{
    partial class frmGiaoDienCSYT
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
            this.buttonHSBADV = new System.Windows.Forms.Button();
            this.buttonHSBA = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý HSBA và dịch vụ HSBA";
            // 
            // buttonHSBADV
            // 
            this.buttonHSBADV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBADV.Location = new System.Drawing.Point(230, 247);
            this.buttonHSBADV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBADV.Name = "buttonHSBADV";
            this.buttonHSBADV.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBADV.TabIndex = 8;
            this.buttonHSBADV.Text = "Hồ sơ bệnh án Dịch vụ";
            this.buttonHSBADV.UseVisualStyleBackColor = false;
            this.buttonHSBADV.Click += new System.EventHandler(this.buttonHSBADV_Click);
            // 
            // buttonHSBA
            // 
            this.buttonHSBA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBA.Location = new System.Drawing.Point(230, 193);
            this.buttonHSBA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBA.Name = "buttonHSBA";
            this.buttonHSBA.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBA.TabIndex = 7;
            this.buttonHSBA.Text = "Hồ sơ bệnh án";
            this.buttonHSBA.UseVisualStyleBackColor = false;
            this.buttonHSBA.Click += new System.EventHandler(this.buttonHSBA_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDangXuat.Location = new System.Drawing.Point(534, 326);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 28);
            this.btnDangXuat.TabIndex = 19;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(230, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thông tin cá nhân";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGiaoDienCSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHSBADV);
            this.Controls.Add(this.buttonHSBA);
            this.Name = "frmGiaoDienCSYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý của Cơ Sở Y Tế";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHSBADV;
        private System.Windows.Forms.Button buttonHSBA;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button button1;
    }
}