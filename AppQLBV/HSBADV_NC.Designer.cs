
namespace AppQLBV
{
    partial class HSBADV_NC
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMaDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgDSHSBA_DV = new System.Windows.Forms.DataGridView();
            this.colMaHSBADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(316, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chi tiết dịch vụ trong hồ sơ bệnh án";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1045, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimMaDV
            // 
            this.txtTimMaDV.Location = new System.Drawing.Point(826, 82);
            this.txtTimMaDV.Name = "txtTimMaDV";
            this.txtTimMaDV.Size = new System.Drawing.Size(213, 22);
            this.txtTimMaDV.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tìm mã DV:";
            // 
            // dgDSHSBA_DV
            // 
            this.dgDSHSBA_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSHSBA_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA_DV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBADV,
            this.colMaDV,
            this.colNgay,
            this.colMaKTV,
            this.colKetQua});
            this.dgDSHSBA_DV.Location = new System.Drawing.Point(13, 125);
            this.dgDSHSBA_DV.Name = "dgDSHSBA_DV";
            this.dgDSHSBA_DV.RowHeadersWidth = 51;
            this.dgDSHSBA_DV.RowTemplate.Height = 24;
            this.dgDSHSBA_DV.Size = new System.Drawing.Size(1107, 372);
            this.dgDSHSBA_DV.TabIndex = 26;
            // 
            // colMaHSBADV
            // 
            this.colMaHSBADV.DataPropertyName = "MAHSBA";
            this.colMaHSBADV.HeaderText = "Mã HSBA";
            this.colMaHSBADV.MinimumWidth = 6;
            this.colMaHSBADV.Name = "colMaHSBADV";
            // 
            // colMaDV
            // 
            this.colMaDV.DataPropertyName = "MADV";
            this.colMaDV.HeaderText = "Mã DV";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            // 
            // colNgay
            // 
            this.colNgay.DataPropertyName = "NGAY";
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            // 
            // colMaKTV
            // 
            this.colMaKTV.DataPropertyName = "MAKTV";
            this.colMaKTV.HeaderText = "Mã KTV";
            this.colMaKTV.MinimumWidth = 6;
            this.colMaKTV.Name = "colMaKTV";
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KETQUA";
            this.colKetQua.HeaderText = "Kết quả";
            this.colKetQua.MinimumWidth = 6;
            this.colKetQua.Name = "colKetQua";
            // 
            // HSBADV_NC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimMaDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgDSHSBA_DV);
            this.Name = "HSBADV_NC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin dịch vụ trong hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.HSBADV_NC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMaDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgDSHSBA_DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
    }
}