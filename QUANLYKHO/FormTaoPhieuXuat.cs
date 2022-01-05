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
    public partial class FormTaoPhieuXuat : Form
    {
        public FormTaoPhieuXuat()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (maPhieuXuat.Text.ToString() == "" || tenNguoiNhan.Text.ToString() == "" ||comboTTTT.SelectedItem.ToString()==""||comboTTGH.SelectedItem.ToString()==""|| soDienThoai.Text.ToString() == "" || diaChi.Text.ToString() == "" ||dataTaoPhieuXuat.Rows[0].Cells["MaSanPham"].Value.ToString() == "" || dataTaoPhieuXuat.Rows[0].Cells["TenSanPham"].Value.ToString() == "" || dataTaoPhieuXuat.Rows[0].Cells["SoLuong"].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng không để trống");
            }
            else
            {

                for (int i = 0; i < (dataTaoPhieuXuat.Rows.Count - 1); i++)
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO PhieuXuatKho(MaPhieuXuat,TenNguoiNhan,SoDienThoai,DiaChi,NgayXuatKho,MaSanPham,TenSanPham,SoLuong,DonGia,TongTien,TTThanhToan,TTGiaoHang) values ('" + maPhieuXuat.Text.ToString() + "'" +
                                            ",N'" + tenNguoiNhan.Text.ToString() + "','" +
                                             soDienThoai.Text.ToString() + "'" +
                                             ",N'" + diaChi.Text.ToString() + "'," +
                                             "'" + ngayXuat.Value.Date.ToString("yyyyMMdd") + "'" +
                                            ",'" + dataTaoPhieuXuat.Rows[i].Cells["MaSanPham"].Value.ToString() + "'" +
                                            ",N'" + dataTaoPhieuXuat.Rows[i].Cells["TenSanPham"].Value.ToString() + "'" +
                                            "," + Convert.ToInt32(dataTaoPhieuXuat.Rows[i].Cells["SoLuong"].Value.ToString()) +
                                             "," + Convert.ToInt32(dataTaoPhieuXuat.Rows[i].Cells["DonGia"].Value.ToString()) +
                                               "," + Convert.ToInt32(dataTaoPhieuXuat.Rows[i].Cells["TongTien"].Value.ToString()) + ",N'" +
                                                comboTTTT.SelectedItem.ToString() + "',N'" +
                                                 comboTTGH.SelectedItem.ToString() + "')", sqlCon);
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                MessageBox.Show("Thêm thành công!");
                this.Close();
                FormDanhSachPhieuXuat fx = new FormDanhSachPhieuXuat();
                fx.Show();
             
                
            }
        }

        private void FormTaoPhieuXuat_Load(object sender, EventArgs e)
        {
            comboTTGH.Items.Add("Đang xử lý");
            comboTTGH.Items.Add("Đang giao");
            comboTTGH.Items.Add("Giao thành công");


            comboTTTT.Items.Add("Chưa thanh toán");
            comboTTTT.Items.Add("Đã thanh toán");

            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }


            sqlCon.Open();

            SqlCommand lenh = new SqlCommand("SELECT DISTINCT TenSanPham  From PhieuNhapKho", sqlCon);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("SP");
            da.Fill(dt);
            TenSanPham.ValueMember = "TenSanPham";
            TenSanPham.DisplayMember = "TenSanPham";
            TenSanPham.DataSource = dt;
        }

        private void dataTaoPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                if (dataTaoPhieuXuat.Rows[e.RowIndex].Cells["SoLuong"].Value != null && dataTaoPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value != null)
                {
                    if (kiemTraDauVaoXuat(dataTaoPhieuXuat.Rows[e.RowIndex].Cells["Soluong"].Value.ToString(), dataTaoPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString()))
                    {
                        dataTaoPhieuXuat.Rows[e.RowIndex].Cells["TongTien"].Value = Convert.ToInt32(dataTaoPhieuXuat.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()) * Convert.ToInt32(dataTaoPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số ở số lượng và đơn giá");
                        dataTaoPhieuXuat.Refresh();

                    }
                }
            }

        }


        public bool kiemTraDauVaoXuat(string soluong, string dongia)
        {
            if (IsValidDecimalNumber(soluong).ToString() == "False" || IsValidDecimalNumber(dongia.ToString()).ToString() == "False")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool IsValidDecimalNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false; //blank/null strings aren't valid decimal numbers
            return !s.Any(c => !(char.IsDigit(c) || c == '.')) && !(s.Count(c => c == '.') > 1);
        }


    }
}
