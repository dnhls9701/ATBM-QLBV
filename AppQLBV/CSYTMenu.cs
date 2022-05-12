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
    public partial class frmGiaoDienCSYT : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmGiaoDienCSYT()
        {
            InitializeComponent();
        }

        private void buttonHSBA_Click(object sender, EventArgs e)
        {
            HSBA_CSYT hSBA_CSYT = new HSBA_CSYT();
            this.Hide();
            hSBA_CSYT.ShowDialog();
            this.Show();
        }

        private void buttonHSBADV_Click(object sender, EventArgs e)
        {
            HSBADV_CSYT hSBADV_CSYT = new HSBADV_CSYT();
            this.Hide();
            hSBADV_CSYT.ShowDialog();
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
