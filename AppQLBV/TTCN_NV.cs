using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace AppQLBV
{
    public partial class TTCN_NV : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public TTCN_NV()
        {
            InitializeComponent();
        }

        private void dgDSHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgDSHSBA.Rows[dgDSHSBA.CurrentCell.RowIndex];
            lblMaNV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            cbPhai.Text = row.Cells[2].Value.ToString();
            dtpNgaySinh.Text = row.Cells[3].Value.ToString();
            txtCMND.Text = row.Cells[4].Value.ToString();
            txtQueQuan.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtCSYT.Text = row.Cells[7].Value.ToString();
            cbVaiTro.Text = row.Cells[8].Value.ToString();
            txtChuyenKhoa.Text = row.Cells[9].Value.ToString();
        }

        private void TTCN_NV_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_XEMTHONGTINNHANVIEN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE DNHLAN.UV_XEMTHONGTINNHANVIEN SET HOTEN = '" + txtHoTen.Text + "', PHAI = '" + cbPhai.Text + "', NGAYSINH = TO_DATE(SUBSTR('" + dtpNgaySinh.Value.Date + "',1,15) ,'MM/DD/YYYY HH:MI:SS'), CMND = '" + txtCMND.Text + "', QUEQUAN = '" + txtQueQuan.Text + "', SODT = '" + txtSDT.Text + "', CSYT = '" + txtCSYT.Text + "', VAITRO = '" + cbVaiTro.Text + "', CHUYENKHOA = '" + txtChuyenKhoa.Text + "' WHERE MANV = '" + lblMaNV.Text + "'";
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin cá nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Cập nhật thông tin cá nhân không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
