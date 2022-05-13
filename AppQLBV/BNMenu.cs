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
    public partial class frmGiaoDienBN : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        public frmGiaoDienBN()
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

        private void buttonTTCN_Click(object sender, EventArgs e)
        {
            TTCN_BN tTCN_BN = new TTCN_BN();
            this.Hide();
            tTCN_BN.ShowDialog();
            this.Show();
        }
    }
}
