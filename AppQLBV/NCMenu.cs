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
    public partial class frmGiaoDienNC : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmGiaoDienNC()
        {
            InitializeComponent();
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

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            HSBA_NC hSBA_NC = new HSBA_NC();
            this.Hide();
            hSBA_NC.ShowDialog();
            this.Show();
        }

        private void buttonHSBADV_Click(object sender, EventArgs e)
        {
            HSBADV_NC hSBADV = new HSBADV_NC();
            this.Hide();
            hSBADV.ShowDialog();
            this.Show();
        }
    }
}
