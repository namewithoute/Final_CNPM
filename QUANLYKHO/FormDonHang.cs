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
namespace QUANLYKHO
{
    public partial class FormDonHang : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");

        public FormDonHang()
        {
            InitializeComponent();
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {

            fillListBox();
            dsMaDon.SelectedIndex = 0;
            string curItem = dsMaDon.SelectedItem.ToString();
            fillGrid(curItem);
            getInfo(curItem);

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
            cmd.CommandText = "SELECT DISTINCT MaDatHang FROM DatHang";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dsMaDon.Items.Add(dr.GetString(0));
            }
            con.Close();
        }
        private void fillGrid(string mdh)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  MaSanPham,TenSanPham, SoLuong,DonGia,TongTien FROM DatHang where MaDatHang = '" + mdh + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataDonHang.DataSource = dt;
        }

        private void dsMaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = dsMaDon.SelectedItem.ToString();
            fillGrid(curItem);
            getInfo(curItem);
        }

        private void getInfo(string mdh)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

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

            cmd.CommandText = "SELECT DISTINCT MaDatHang,TenDaiLy,DiaChi,SoDienThoai,NgayDatHang,ThanhToan FROM DatHang where MaDatHang = '" + mdh + "'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                maDon.Text = dt.Rows[0]["MaDatHang"].ToString();
                tenDaiLy.Text = dt.Rows[0]["TenDaiLy"].ToString();
                soDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                diaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                ngayDatHang.Text = dt.Rows[0]["NgayDatHang"].ToString();
                htThanhToan.Text = dt.Rows[0]["ThanhToan"].ToString();
            }

        }

        private void btnChuyenPhieuXuat_Click(object sender, EventArgs e)
        {
            string curItem = dsMaDon.SelectedItem.ToString();

            for (int i = 0; i < (dataDonHang.Rows.Count - 1); i++)
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO PhieuXuatKho(MaPhieuXuat,TenNguoiNhan,SoDienThoai,DiaChi,NgayXuatKho,MaSanPham,TenSanPham,SoLuong,DonGia,TongTien,TTThanhToan,TTGiaoHang) values ('" + maDon.Text.ToString() + "'" +
                                            ",N'" + tenDaiLy.Text.ToString() + "','" +
                                             soDienThoai.Text.ToString() + "'" +
                                             ",N'" + diaChi.Text.ToString() + "'," +
                                             "'" + ngayDatHang.Value.Date.ToString("yyyyMMdd") + "'" +
                                            ",'" + dataDonHang.Rows[i].Cells["MaSanPham"].Value.ToString() + "'" +
                                            ",N'" + dataDonHang.Rows[i].Cells["TenSanPham"].Value.ToString() + "'" +
                                            "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["SoLuong"].Value.ToString()) +
                                             "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["DonGia"].Value.ToString()) +
                                               "," + Convert.ToInt32(dataDonHang.Rows[i].Cells["TongTien"].Value.ToString()) + ",N'Chưa thanh toán',N'Đang xử lý')" ,con);

                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "DELETE FROM DatHang where MaDatHang ='" + curItem + "'";


                if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                con.Close();
                }

    

           
            MessageBox.Show("Thêm thành công!");
                this.Close();
                FormDonHang ds = new FormDonHang();
                ds.Show();
        }

        private void danhSáchPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuNhap fn = new FormDanhSachPhieuNhap();
            this.Hide();
            fn.Show();
        }

        private void danhSáchPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuXuat fx = new FormDanhSachPhieuXuat();
            fx.Show();
            this.Hide();
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

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe fk = new FormThongKe();
            fk.Show();
            this.Hide();
        }
    }
}
