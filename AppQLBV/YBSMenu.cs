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
    public partial class frmGiaoDienYBS : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmGiaoDienYBS()
        {
            InitializeComponent();
        }

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            HSBA_HSBADV_YBS hSBA_HSBADV = new HSBA_HSBADV_YBS();
            this.Hide();
            hSBA_HSBADV.ShowDialog();
            this.Show();
        }

        private void buttonHSBN_Click(object sender, EventArgs e)
        {
            HSBN_YBS hSBN_YBS = new HSBN_YBS();
            this.Hide();
            hSBN_YBS.ShowDialog();
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
