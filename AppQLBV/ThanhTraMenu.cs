using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLBV
{
    public partial class frmGiaoDienThanhTra : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmGiaoDienThanhTra()
        {
            InitializeComponent();
        }

        private void buttonHSBADV_Click(object sender, EventArgs e)
        {
            HSBADV_ThanhTra hSBADV_ThanhTra = new HSBADV_ThanhTra();
            this.Hide();
            hSBADV_ThanhTra.ShowDialog();
            this.Show();
        }

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            HSBA_ThanhTra hSBA_ThanhTra = new HSBA_ThanhTra();
            this.Hide();
            hSBA_ThanhTra.ShowDialog();
            this.Show();
        }

        private void buttonHSBN_Click(object sender, EventArgs e)
        {
            HSBN_ThanhTra hSBN_ThanhTra = new HSBN_ThanhTra();
            this.Hide();
            hSBN_ThanhTra.ShowDialog();
            this.Show();
        }

        private void buttonCSYT_Click(object sender, EventArgs e)
        {
            CSYT_ThanhTra cSYT_ThanhTra = new CSYT_ThanhTra();
            this.Hide();
            cSYT_ThanhTra.ShowDialog();
            this.Show();
        }

        private void buttonHSNV_Click(object sender, EventArgs e)
        {
            HSNV_ThanhTra hSNV_ThanhTra = new HSNV_ThanhTra();
            this.Hide();
            hSNV_ThanhTra.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap.ShowDialog();
                this.Show();
            }
            else if (result == DialogResult.No)
            {
                //..
            }
        }
    }
}
