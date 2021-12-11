using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHO
{
    public partial class FormDanhSachPhieuXuat : Form
    {
        public FormDanhSachPhieuXuat()
        {
            InitializeComponent();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Name != "FormDanhSachPhieuNhap")
            {
                this.Hide();
                FormDanhSachPhieuNhap dsnhap = new FormDanhSachPhieuNhap();
                dsnhap.Show();
            }
           
        }

        private void danhSáchPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Name != "FormDanhSachPhieuXuat")
            {
                this.Hide();
                FormDanhSachPhieuXuat dsxuat = new FormDanhSachPhieuXuat();
                dsxuat.Show();
            }
        }

        private void tạoPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoPhieuNhap taoPhieuNhap = new FormTaoPhieuNhap();
            taoPhieuNhap.Show();
        }

        private void tạoPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoPhieuXuat taoPhieuXuat = new FormTaoPhieuXuat();
            taoPhieuXuat.Show();
        }
    }
}
