
namespace AppQLBV
{
    partial class frmGiaoDienNC
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
            this.buttonHSBADV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHSBA = new System.Windows.Forms.Button();
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
            // buttonHSBADV
            // 
            this.buttonHSBADV.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBADV.Location = new System.Drawing.Point(205, 252);
            this.buttonHSBADV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBADV.Name = "buttonHSBADV";
            this.buttonHSBADV.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBADV.TabIndex = 20;
            this.buttonHSBADV.Text = "Dịch vụ hồ sơ bệnh án";
            this.buttonHSBADV.UseVisualStyleBackColor = false;
            this.buttonHSBADV.Click += new System.EventHandler(this.buttonHSBADV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản lý HSBA, dịch vụ HSBA";
            // 
            // buttonHSBA
            // 
            this.buttonHSBA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHSBA.Location = new System.Drawing.Point(205, 177);
            this.buttonHSBA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHSBA.Name = "buttonHSBA";
            this.buttonHSBA.Size = new System.Drawing.Size(204, 37);
            this.buttonHSBA.TabIndex = 18;
            this.buttonHSBA.Text = "Hồ sơ bệnh án";
            this.buttonHSBA.UseVisualStyleBackColor = false;
            this.buttonHSBA.Click += new System.EventHandler(this.buttonHSBA_Click);
            // 
            // frmGiaoDienNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 463);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.buttonHSBADV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHSBA);
            this.Name = "frmGiaoDienNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý của Nghiên cứu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button buttonHSBADV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHSBA;
    }
}