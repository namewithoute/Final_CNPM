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
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");
        public FormDanhSachPhieuXuat()
        {
            InitializeComponent();
        }



        public void fill_grid(string mpn)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaSanPham, TenSanPham, SoLuong,DonGia,TongTien FROM PhieuXuatKho where MaPhieuNhap = '" + mpn + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDanhSachXuat.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void fillListBox()
        {
            SqlCommand cmd = new SqlCommand();
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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT STTSanPhamXuat, MaSanPham,TenSanPham, SoLuong,DonGia,TongTien FROM PhieuXuatKho where MaPhieuXuat = '" + mpx + "'";
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

            SqlCommand lenh = new SqlCommand("SELECT DISTINCT TenSanPham  From PhieuXuatKho", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("SP");
            da.Fill(dt);
            TenSanPham.DataSource = dt;
            TenSanPham.ValueMember = "TenSanPham";
            TenSanPham.DisplayMember = "TenSanPham";
        }


        private void FormDanhSachPhieuXuat_Load(object sender, EventArgs e)
        {
        
            fillListBox();
            dsMaXuat.SelectedIndex = 0;
            string curItem = dsMaXuat.SelectedItem.ToString();
            fillCombo();

            fillGrid(curItem);

        }

        private void dataDanhSachXuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataDanhSachXuat.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataDanhSachXuat.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataDanhSachXuat.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dsMaXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = dsMaXuat.SelectedItem.ToString();
            getInfo(curItem);
        }


        private void getInfo(string mpx)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("INFO");

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT DISTINCT MaPhieuXuat,TenNguoiNhan,SoDienThoai,DiaChi,NgayXuatKho FROM PhieuXuatKho where MaPhieuXuat = '"+mpx+"'";
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                maPhieuXuat.Text = dt.Rows[0]["MaPhieuXuat"].ToString();
                tenNguoiNhan.Text = dt.Rows[0]["TenNguoiNhan"].ToString();
                soDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                diaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                ngayXuatKho.Text = dt.Rows[0]["NgayXuatKho"].ToString();
            }
            string curItem = dsMaXuat.SelectedItem.ToString();
            fillGrid(curItem);
            }
    }
}
