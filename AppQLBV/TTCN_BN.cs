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
    public partial class TTCN_BN : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public TTCN_BN()
        {
            InitializeComponent();
        }

        private void TTCN_BN_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DNHLAN.UV_XEMTHONGTINBENHNHAN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgDSHSBA.DataSource = dt.DefaultView;
            dr.Close();
        }

        private void dgDSHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgDSHSBA.Rows[dgDSHSBA.CurrentCell.RowIndex];
            lblMaBN.Text = row.Cells[0].Value.ToString();
            txtCSYT.Text = row.Cells[1].Value.ToString();
            txtBN.Text = row.Cells[2].Value.ToString();
            txtCMND.Text = row.Cells[3].Value.ToString();
            dtpNgay.Text = row.Cells[4].Value.ToString();
            txtSN.Text = row.Cells[5].Value.ToString();
            txtTD.Text = row.Cells[6].Value.ToString();
            txtQH.Text = row.Cells[7].Value.ToString();
            txtTinhTP.Text = row.Cells[8].Value.ToString();
            txtTSB.Text = row.Cells[9].Value.ToString();
            txtTSBGD.Text = row.Cells[10].Value.ToString();
            txtDiUngThuoc.Text = row.Cells[11].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE DNHLAN.UV_XEMTHONGTINBENHNHAN SET MACSYT = '" + txtCSYT.Text + "',TENBN = '" + txtBN.Text + "',CMND = '" + txtCMND.Text + "',NGAYSINH = TO_DATE(SUBSTR('" + dtpNgay.Value.Date + "',1,15) ,'MM/DD/YYYY HH:MI:SS'), SONHA = '" + txtSN.Text + "', TENDUONG = '" + txtTD.Text + "', QUANHUYEN = '" + txtQH.Text + "', TINHTP = '" + txtTinhTP.Text + "', TIENSUBENH = '" + txtTSB.Text + "', TIENSUBENHGD = '" + txtTSBGD.Text + "', DIUNGTHUOC = '" + txtDiUngThuoc.Text + "' WHERE MABN = '" + lblMaBN.Text + "'";
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
