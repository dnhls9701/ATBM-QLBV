
namespace AppQLBV
{
    partial class frmGiaoDienBN
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTTCN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDangXuat.Location = new System.Drawing.Point(504, 370);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 28);
            this.btnDangXuat.TabIndex = 21;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản lý thông tin cá nhân";
            // 
            // buttonTTCN
            // 
            this.buttonTTCN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonTTCN.Location = new System.Drawing.Point(227, 210);
            this.buttonTTCN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTTCN.Name = "buttonTTCN";
            this.buttonTTCN.Size = new System.Drawing.Size(204, 37);
            this.buttonTTCN.TabIndex = 18;
            this.buttonTTCN.Text = "Xem thông tin cá nhân";
            this.buttonTTCN.UseVisualStyleBackColor = false;
            this.buttonTTCN.Click += new System.EventHandler(this.buttonTTCN_Click);
            // 
            // frmGiaoDienBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 463);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTTCN);
            this.Name = "frmGiaoDienBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý của Bệnh nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTTCN;
    }
}