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
            string sql = "DECLARE @columns NVARCHAR(MAX) = '', @sql NVARCHAR(MAX) = '';"
                            + "SELECT @columns += QUOTENAME(Xe.tenXe) + ',' FROM Xe ORDER BY tenXe; "
                            + "SET @columns = LEFT(@columns, LEN(@columns) - 1);"
                            + "SET @sql ='"
                            + "select * from (select tenXe, maTourMau, tenTour, chiPhi from bang) a"
                            + "pivot(sum(chiPhi) for tenXe in (' + @columns +')) as pivot_table';"
                            + "EXECUTE sp_executesql @sql;";
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
            cmd.cl
            cmd.Dispose();
        }
    }
}
