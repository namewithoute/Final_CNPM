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
    public partial class FormDanhSachPhieuNhap : Form
    {
        public FormDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            PhieuNhapCONTROLLER dsMaPhieu = new PhieuNhapCONTROLLER();

            List<String> dsPhieu1 = new List<string>();

            for (int i = 0; i < dsMaPhieu.loadMaPhieuNhap().Count; i++)
            {
                //kiểm tra danh sách phiếu nhập có bị trùng hay không
                if (!dsPhieu1.Contains(dsMaPhieu.loadMaPhieuNhap()[i]))
                {
                    dsPhieu1.Add(dsMaPhieu.loadMaPhieuNhap()[i]);
                    ds_phieunhap.Items.Add(dsMaPhieu.loadMaPhieuNhap()[i]);
                }
            }

            PhieuNhapCONTROLLER dsPhieuNhap = new PhieuNhapCONTROLLER();
            ds_phieunhap.SelectedIndex = 0;
            dataDanhSachPhieuNhap.DataSource = dsPhieuNhap.loadAll(ds_phieunhap.Items[0].ToString());

        }



        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ds_phieunhap_SelectedIndexChanged(object sender, EventArgs e)
        {


            PhieuNhapCONTROLLER dsPhieuNhap = new PhieuNhapCONTROLLER();

            string curItem = ds_phieunhap.SelectedItem.ToString();
            dataDanhSachPhieuNhap.DataSource = dsPhieuNhap.loadAll(curItem);
            tenNhanVien.Text = dsPhieuNhap.getName(curItem);
            maPhieuNhap.Text = curItem;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void danhSáchPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Name == "FormDanhSachPhieuNhap") { }
            else
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa phiếu nhập này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string curItem = ds_phieunhap.SelectedItem.ToString();
                PhieuNhapCONTROLLER phieunhap = new PhieuNhapCONTROLLER();

                phieunhap.xoaPhieuNhap(curItem);
                MessageBox.Show("Xóa thành công");
                this.Close();
                FormDanhSachPhieuNhap main = new FormDanhSachPhieuNhap();
                main.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           
        }
    }
}
