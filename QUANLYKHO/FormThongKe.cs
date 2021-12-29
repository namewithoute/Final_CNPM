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
    public partial class FormThongKe : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            ngayThongKe.Format = DateTimePickerFormat.Custom;
            ngayThongKe.CustomFormat = "MM/yyyy";
            ngayThongKe.ShowUpDown = true;
        }

       private void fillDSNhap(string ngaynhap)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaSanPham AS MaSanPhamNhap,TenSanPham AS TenSanPhamNhap, SoLuong AS SoLuongNhap, DonGia AS DonGiaNhap, TongTien AS TongTienNhap FROM PhieuNhapKho where NgayNhapkho like '%"+ngaynhap+"%'" ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDsNhap.DataSource = dt;
            int tongTien = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                tongTien += Convert.ToInt32(dt.Rows[i]["TongTienNhap"].ToString());
            }
            txtTienNhap.Text = tongTien.ToString();
            
        }

       

        private void fillDSXuat(string ngayxuat)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaSanPham AS MaSanPhamXuat,TenSanPham AS TenSanPhamXuat, SoLuong AS SoLuongXuat, DonGia AS DonGiaXuat, TongTien AS TongTienXuat FROM PhieuXuatKho where NgayXuatKho like '%" + ngayxuat + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int tongTienXuat = 0 ;
            dataDsXuat.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongTienXuat += Convert.ToInt32(dt.Rows[i]["TongTienXuat"].ToString());
            }
            txtTienXuat.Text = tongTienXuat.ToString();
        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            string ngay = ngayThongKe.Value.Date.ToString("yyyy-MM");
            fillDSNhap(ngay);
            fillDSXuat(ngay);
        }
    }
}
