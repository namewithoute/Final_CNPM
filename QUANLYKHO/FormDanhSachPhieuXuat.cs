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
using System.Collections;

namespace QUANLYKHO
{
    public partial class FormDanhSachPhieuXuat : Form
    {
        string id;
        int id1, delete_id;
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");
        public FormDanhSachPhieuXuat()
        {
            InitializeComponent();
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void fillListBox()
        {
            SqlCommand cmd = new SqlCommand();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT DISTINCT MaPhieuXuat FROM PhieuXuatKho";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dsMaXuat.Items.Add(dr.GetString(0));
            }
            con.Close();


        }

        private void fillGrid(string mpx)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT STTSanPhamXuat, TenSanPham,MaSanPham, SoLuong,DonGia,TongTien FROM PhieuXuatKho where MaPhieuXuat = '" + mpx + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataDanhSachXuat.DataSource = dt;
        }


        private void fillCombo()
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


            con.Open();

            SqlCommand lenh = new SqlCommand("SELECT DISTINCT TenSanPham  From PhieuNhapKho", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("SP");
            da.Fill(dt);
            TenSanPham.ValueMember = "TenSanPham";
            TenSanPham.DisplayMember = "TenSanPham";
            TenSanPham.DataSource = dt;

        }


        private void FormDanhSachPhieuXuat_Load(object sender, EventArgs e)
        {

            fillListBox();
            dsMaXuat.SelectedIndex = 0;
            string curItem = dsMaXuat.SelectedItem.ToString();
            fillCombo();
            getInfo(curItem);
            comboTTGiaoHang.Items.Add("Đang xử lý");
            comboTTGiaoHang.Items.Add("Đang giao");
            comboTTGiaoHang.Items.Add("Giao thành công");


            comboTTThanhToan.Items.Add("Chưa thanh toán");
            comboTTThanhToan.Items.Add("Đã thanh toán");

        }

        private void dataDanhSachXuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dsMaXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = dsMaXuat.SelectedItem.ToString();
            fillCombo();
            getInfo(curItem);
        }


        private void getInfo(string mpx)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("INFO");

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT DISTINCT MaPhieuXuat,TenNguoiNhan,SoDienThoai,DiaChi,NgayXuatKho,TTGiaoHang,TTThanhToan FROM PhieuXuatKho where MaPhieuXuat = '" + mpx + "'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                maPhieuXuat.Text = dt.Rows[0]["MaPhieuXuat"].ToString();
                tenNguoiNhan.Text = dt.Rows[0]["TenNguoiNhan"].ToString();
                soDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                diaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                ngayXuatKho.Text = dt.Rows[0]["NgayXuatKho"].ToString();
                comboTTThanhToan.Text = dt.Rows[0]["TTThanhToan"].ToString();
                comboTTGiaoHang.Text = dt.Rows[0]["TTGiaoHang"].ToString();

            }


            string curItem = dsMaXuat.SelectedItem.ToString();
            fillGrid(curItem);
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa phiếu xuất này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = con.CreateCommand();
                string curItem = dsMaXuat.SelectedItem.ToString();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM PhieuXuatKho where MaPhieuXuat = '" + curItem + "'";
                cmd.ExecuteNonQuery();




                FormDanhSachPhieuXuat objFrmGrafik = new FormDanhSachPhieuXuat();
                this.Dispose();
                objFrmGrafik.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM PhieuXuatKho where STTSanPhamXuat = " + delete_id + "";
            cmd.ExecuteNonQuery();
            string curItem = dsMaXuat.SelectedItem.ToString();
            fillCombo();
            fillGrid(curItem);

        }

        private void dataDanhSachXuat_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                delete_id = Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["STTSanPhamXuat"].Value.ToString());
                this.contextMenuStrip1.Show(this.dataDanhSachXuat, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void comboTTGiaoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


            con.Open();
            string curItem = dsMaXuat.SelectedItem.ToString();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE PhieuXuatKho set TTGiaoHang = N'" + comboTTGiaoHang.SelectedItem.ToString() + "' where MaPhieuXuat ='" + curItem + "'";
            cmd.ExecuteNonQuery();
            fillCombo();
            fillGrid(curItem);


        }

        private void tenNguoiNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTTThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }


            con.Open();
            string curItem = dsMaXuat.SelectedItem.ToString();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE PhieuXuatKho set TTThanhToan = N'" + comboTTThanhToan.SelectedItem.ToString() + "' where MaPhieuXuat ='" + curItem + "'";
            cmd.ExecuteNonQuery();
            fillCombo();
            fillGrid(curItem);

        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuNhap fn = new FormDanhSachPhieuNhap();
            fn.Show();
            this.Hide();
        }

        private void danhSáchPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoPhieuNhap fnk = new FormTaoPhieuNhap();
            fnk.Show();
        }

        private void tạoPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaoPhieuXuat fxk = new FormTaoPhieuXuat();
            fxk.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonHang dh = new FormDonHang();
            dh.Show();
            this.Hide();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe();
            this.Hide();
            tk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string curItem = dsMaXuat.SelectedItem.ToString();
            FormInPhieuX inPX = new FormInPhieuX();
            inPX.setQuery("SELECT * FROM PhieuXuatKho WHERE MaPhieuXuat='" + curItem + "'");
            inPX.ShowDialog();
        }

        private void dataDanhSachXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                id = dataDanhSachXuat.Rows[e.RowIndex].Cells["STTSanPhamXuat"].Value.ToString();


                if (id == "")
                {
                    id1 = 0;
                }
                else
                {
                    id1 = Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["STTSanPhamXuat"].Value.ToString());
                }

                if (id1 == 0)
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO PhieuXuatKho(MaPhieuXuat,TenNguoiNhan,SoDienThoai,DiaChi,NgayXuatKho,MaSanPham,TenSanPham,SoLuong, DonGia,TongTien) values ('" + maPhieuXuat.Text.ToString() + "'" +
                                    ",N'" + tenNguoiNhan.Text.ToString() + "','" +
                                     soDienThoai.Text.ToString() + "'" +
                                    ",N'" + diaChi.Text.ToString() + "'" +
                                    ",'" + ngayXuatKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                    ",'" + dataDanhSachXuat.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString() +
                                     "',N'" + Convert.ToString((dataDanhSachXuat.Rows[e.RowIndex].Cells["TenSanPham"] as DataGridViewComboBoxCell).FormattedValue.ToString()) +
                                       "'," + 0 +
                                        "," + 0 +
                                         "," + 0 + ")";
                    cmd.ExecuteNonQuery();
                    string curItem = dsMaXuat.SelectedItem.ToString();
                    fillGrid(curItem);



                }
                else
                {

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE PhieuXuatKho set MaPhieuXuat ='" + maPhieuXuat.Text.ToString() + "'," +
                        "TenNguoiNhan=N'" + tenNguoiNhan.Text.ToString() + "'," +
                        "SoDienThoai='" + soDienThoai.Text.ToString() + "'," +
                        "DiaChi=N'" + diaChi.Text.ToString() + "'," +
                        "NgayXuatKho='" + ngayXuatKho.Value.Date.ToString("yyyyMMdd") + "'," +
                        "MaSanPham='" + dataDanhSachXuat.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString() + "'," +
                        "TenSanPham=N'" + Convert.ToString((dataDanhSachXuat.Rows[e.RowIndex].Cells["TenSanPham"] as DataGridViewComboBoxCell).FormattedValue.ToString()) + "'," +
                        "SoLuong=" + Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()) + "," +
                         "DonGia=" + Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString()) + "," +
                         "TongTien=" + Convert.ToInt32(dataDanhSachXuat.Rows[e.RowIndex].Cells["TongTien"].Value.ToString()) + "" +


                        "Where STTSanPhamXuat = " + id1 + "";

                    cmd.ExecuteNonQuery();
                    string curItem = dsMaXuat.SelectedItem.ToString();
                    fillGrid(curItem);

                }
            }
        }
    }
}
