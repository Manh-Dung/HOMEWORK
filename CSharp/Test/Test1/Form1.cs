using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            dgvTourMau.DataSource = form.ShowGV();

            
        }
        public DataTable ShowGV()
        {
            Form1 form = new Form1();
            string sql = "select * from Account";
            DataTable dt = new DataTable();
            dt = form.GetTable(sql);
            return dt;
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MOTHER-FUCKER;Initial Catalog=QLDuLich;Integrated Security=True");
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MOTHER-FUCKER;Initial Catalog=QLDuLich;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Clone();
            cmd.Dispose();
        }

        private void dgvTourMau_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cot = e.ColumnIndex;
            if (cot == 1)
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void dgvTourMau_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtUser.Text = dgvTourMau.Rows.
        }
    }
}
