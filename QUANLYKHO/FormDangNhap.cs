using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;
namespace QUANLYKHO
{
    public partial class FormDangNhap : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");

        public FormDangNhap()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string taiKhoan = taiKhoan_text.Text;
            string matKhau = matKhau_text.Text;

            SqlCommand cmd = new SqlCommand();
            int count = 0;
            cmd.Connection = con;
            cmd.CommandText = "SELECT *  FROM Account where TaiKhoan = '"+taiKhoan+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count += 1;   
            }
            con.Close();

            if (count != 0)
            {
                FormDanhSachPhieuNhap dsPhieuNhap = new FormDanhSachPhieuNhap();
                dsPhieuNhap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");

            }

        }
    }
}
