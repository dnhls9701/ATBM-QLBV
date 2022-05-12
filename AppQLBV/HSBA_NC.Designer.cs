
namespace AppQLBV
{
    partial class HSBA_NC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimHSBA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDSHSBA = new System.Windows.Forms.DataGridView();
            this.colMaHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHSBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCSYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(399, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Chi tiết hồ sơ bệnh án";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.LightGray;
            this.btnTim.Location = new System.Drawing.Point(1046, 69);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 31);
            this.btnTim.TabIndex = 32;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimHSBA
            // 
            this.txtTimHSBA.Location = new System.Drawing.Point(827, 74);
            this.txtTimHSBA.Name = "txtTimHSBA";
            this.txtTimHSBA.Size = new System.Drawing.Size(213, 22);
            this.txtTimHSBA.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm HSBA:";
            // 
            // dgDSHSBA
            // 
            this.dgDSHSBA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDSHSBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSHSBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHSBA,
            this.colMaBN,
            this.colNgayHSBA,
            this.colChanDoan,
            this.colMaBS,
            this.colMaKhoa,
            this.colMaCSYT,
            this.colKetLuan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDSHSBA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDSHSBA.Location = new System.Drawing.Point(12, 118);
            this.dgDSHSBA.Name = "dgDSHSBA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDSHSBA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDSHSBA.RowHeadersWidth = 51;
            this.dgDSHSBA.RowTemplate.Height = 24;
            this.dgDSHSBA.Size = new System.Drawing.Size(1107, 381);
            this.dgDSHSBA.TabIndex = 29;
            // 
            // colMaHSBA
            // 
            this.colMaHSBA.DataPropertyName = "MAHSBA";
            this.colMaHSBA.HeaderText = "Mã HSBA";
            this.colMaHSBA.MinimumWidth = 6;
            this.colMaHSBA.Name = "colMaHSBA";
            // 
            // colMaBN
            // 
            this.colMaBN.DataPropertyName = "MABN";
            this.colMaBN.HeaderText = "Mã BN";
            this.colMaBN.MinimumWidth = 6;
            this.colMaBN.Name = "colMaBN";
            // 
            // colNgayHSBA
            // 
            this.colNgayHSBA.DataPropertyName = "NGAY";
            this.colNgayHSBA.HeaderText = "Ngày";
            this.colNgayHSBA.MinimumWidth = 6;
            this.colNgayHSBA.Name = "colNgayHSBA";
            // 
            // colChanDoan
            // 
            this.colChanDoan.DataPropertyName = "CHUANDOAN";
            this.colChanDoan.HeaderText = "Chẩn đoán";
            this.colChanDoan.MinimumWidth = 6;
            this.colChanDoan.Name = "colChanDoan";
            // 
            // colMaBS
            // 
            this.colMaBS.DataPropertyName = "MABS";
            this.colMaBS.HeaderText = "Mã BS";
            this.colMaBS.MinimumWidth = 6;
            this.colMaBS.Name = "colMaBS";
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.DataPropertyName = "MAKHOA";
            this.colMaKhoa.HeaderText = "Mã khoa";
            this.colMaKhoa.MinimumWidth = 6;
            this.colMaKhoa.Name = "colMaKhoa";
            // 
            // colMaCSYT
            // 
            this.colMaCSYT.DataPropertyName = "MACSYT";
            this.colMaCSYT.HeaderText = "Mã CSYT";
            this.colMaCSYT.MinimumWidth = 6;
            this.colMaCSYT.Name = "colMaCSYT";
            // 
            // colKetLuan
            // 
            this.colKetLuan.DataPropertyName = "KETLUAN";
            this.colKetLuan.HeaderText = "Kết luận";
            this.colKetLuan.MinimumWidth = 6;
            this.colKetLuan.Name = "colKetLuan";
            // 
            // HSBA_NC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimHSBA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSHSBA);
            this.Name = "HSBA_NC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hồ sơ bệnh án";
            this.Load += new System.EventHandler(this.HSBA_NC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSHSBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimHSBA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDSHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHSBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCSYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetLuan;
    }
}