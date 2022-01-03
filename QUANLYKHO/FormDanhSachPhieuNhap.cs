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
using System.Activities.Statements;

namespace QUANLYKHO
{
    public partial class FormDanhSachPhieuNhap : Form
    {

        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");
        string id;
        int id1, delete_id;

        public FormDanhSachPhieuNhap()
        {
            InitializeComponent();
        }



        private void FormDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            fillListBox();

            ds_phieunhap.SelectedIndex = 0;
            string curItem = ds_phieunhap.SelectedItem.ToString();
            fillName(curItem);
            fill_grid(curItem);
        }

        private void fillListBox()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT MaPhieuNhap FROM PhieuNhapKho";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ds_phieunhap.Items.Add(dr.GetString(0));
            }
            con.Close();
        }
        private void fillName(string mpx)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT TenNhanVien,NgayNhapKho FROM PhieuNhapKho where MaPhieuNhap ='" + mpx + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tenNhanVien.Text = dr.GetString(0);
                ngayNhapKho.Value = dr.GetDateTime(1);
            }
            con.Close();
        }


        public void fill_grid(string mpn)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT STTSanPham, MaSanPham,TenSanpham, SoLuong,DonGia,TongTien FROM PhieuNhapKho where MaPhieuNhap = '" + mpn + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDanhSachPhieuNhap.DataSource = dt;

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



            string curItem = ds_phieunhap.SelectedItem.ToString();
            maPhieuNhap.Text = curItem;
            fillName(curItem);

            fill_grid(curItem);

            //dataDanhSachPhieuNhap.DataSource = dsPhieuNhap.loadAll(curItem);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maPhieuNhap_Click(object sender, EventArgs e)
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
                FormDanhSachPhieuXuat formDSXuat = new FormDanhSachPhieuXuat();
                formDSXuat.Show();
            }
        }

        private void tạoPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormTaoPhieuNhap taoPhieuNhap = new FormTaoPhieuNhap();
            taoPhieuNhap.ShowDialog();
            this.Hide();
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
                SqlCommand cmd = con.CreateCommand();
                string curItem = ds_phieunhap.SelectedItem.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM PhieuNhapKho where MaPhieuNhap = '" + curItem + "'";
                cmd.ExecuteNonQuery();




                FormDanhSachPhieuNhap objFrmGrafik = new FormDanhSachPhieuNhap();
                this.Dispose();
                objFrmGrafik.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }


        }




        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataDanhSachPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                id = dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["STTSanPham"].Value.ToString();


                if (id == "")
                {
                    id1 = 0;
                }
                else
                {
                    id1 = Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["STTSanPham"].Value.ToString());
                }

                if (id1 == 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO PhieuNhapKho(MaPhieuNhap,TenNhanVien,NgayNhapKho,MaSanPham,TenSanPham,SoLuong,DonGia,TongTien) values ('" + maPhieuNhap.Text.ToString() + "'" +
                                    ",N'" + tenNhanVien.Text.ToString() + "','" +
                                     ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                    ",'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString() + "'" +
                                    ",N'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString() + "'" +
                                    "," + 0 +
                                     "," + 0 +
                                       "," + 0 + ")";
                    cmd.ExecuteNonQuery();
                    string curItem = ds_phieunhap.SelectedItem.ToString();

                    fill_grid(curItem);



                }
                else
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE PhieuNhapKho set MaPhieuNhap ='" + maPhieuNhap.Text.ToString() + "'," +
                        "TenNhanVien=N'" + tenNhanVien.Text.ToString() + "'," +
                        "NgayNhapKho='" + ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'," +
                        "MaSanPham='" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString() + "'," +
                        "TenSanPham=N'" + dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["TenSanPham"].Value.ToString() + "'," +
                        "SoLuong=" + Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()) + "," +
                        "DonGia=" + Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["DonGia"].Value.ToString()) + "," +
                        "TongTien=" + Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["TongTien"].Value.ToString()) + " " +
                        "Where STTSanPham = " + id1 + "";

                    cmd.ExecuteNonQuery();
                    string curItem = ds_phieunhap.SelectedItem.ToString();

                    fill_grid(curItem);

                }
            }


        }

        private void dataDanhSachPhieuNhap_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(dataDanhSachPhieuNhap.Rows[e.RowIndex].Cells["STTSanPham"].Value.ToString());
                this.contextMenuStrip1.Show(this.dataDanhSachPhieuNhap, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void đơnHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDonHang fd = new FormDonHang();
            fd.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe fm = new FormThongKe();
            fm.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM PhieuNhapKho where STTSanPham = " + delete_id + "";
            cmd.ExecuteNonQuery();
            string curItem = ds_phieunhap.SelectedItem.ToString();

            fill_grid(curItem);

        }






    }
}
