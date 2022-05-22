using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using BUS;
using DTO;
using DAL;

namespace FormLogin
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FCreNewAcc f = new FCreNewAcc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MOTHER-FUCKER;Initial Catalog=QLGiangDay;Integrated Security=True");
            try
            {
                conn.Open();
                gv_DTO.UserName = txtTaiKhoan.Text;
                gv_DTO.PassWord = txtMatKhau.Text;
                string sql = "select * from Account where userName = '" + gv_DTO.UserName + "' and passWord = '" + gv_DTO.PassWord + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    if (gv_BUS.CheckQuyen(gv_DTO.UserName, gv_DTO.PassWord) == 0)
                    {
                        FMain f = new FMain();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    if (gv_BUS.CheckQuyen(gv_DTO.UserName, gv_DTO.PassWord) == 1)
                    {
                        FMain f = new FMain();
                        this.Hide();
                        f.themTK.Enabled = true;
                        f.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!" + ex.Message);
            }

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }
    }
}
