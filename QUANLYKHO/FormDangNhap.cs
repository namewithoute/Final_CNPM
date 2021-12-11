using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHO.CONTROLLER;
namespace QUANLYKHO
{
    public partial class FormDangNhap : Form
    {
        private PhieuNhapCONTROLLER phieunhap = new PhieuNhapCONTROLLER();
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
            string taiKhoan = taiKhoan_text.Text;
            string matKhau = matKhau_text.Text;
            DangNhapCONTROLLER getUser = new DangNhapCONTROLLER();
            if (getUser.findUser(taiKhoan, matKhau) != null)
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
