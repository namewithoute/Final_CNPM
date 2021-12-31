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
    public partial class FormTaoPhieuNhap : Form
    {
        public FormTaoPhieuNhap()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (tenNhanVien.Text.ToString() == "" || maPhieuNhap.Text.ToString() == "" || dsNhap.Rows[0].Cells["MaSanPham"].Value.ToString() == "" || dsNhap.Rows[0].Cells["TenSanPham"].Value.ToString() == "") 
            {
                MessageBox.Show("Vui lòng không để trống");
            }
            
            else {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True");
                for (int i = 0; i < (dsNhap.Rows.Count - 1); i++)
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO PhieuNhapKho(MaPhieuNhap,TenNhanVien,NgayNhapKho,MaSanPham,TenSanPham,SoLuong,DonGia,TongTien) values ('" + maPhieuNhap.Text.ToString() + "'" +
                                            ",N'" + tenNhanVien.Text.ToString() + "','" +
                                             ngayNhapKho.Value.Date.ToString("yyyyMMdd") + "'" +
                                            ",'" + dsNhap.Rows[i].Cells["MaSanPham"].Value.ToString() + "'" +
                                            ",N'" + dsNhap.Rows[i].Cells["TenSanPham"].Value.ToString() + "'" +
                                            "," + Convert.ToInt32(dsNhap.Rows[i].Cells["SoLuong"].Value.ToString()) +
                                             "," + Convert.ToInt32(dsNhap.Rows[i].Cells["DonGia"].Value.ToString()) +
                                               "," + Convert.ToInt32(dsNhap.Rows[i].Cells["TongTien"].Value.ToString()) + ")", sqlCon);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                MessageBox.Show("Thêm thành công!");
                this.Close();
                FormDanhSachPhieuNhap ds = new FormDanhSachPhieuNhap();
                ds.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void phieuNhapHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dsNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > -1)
            {
                
                if (dsNhap.Rows[e.RowIndex].Cells["SoLuong"].Value != null && dsNhap.Rows[e.RowIndex].Cells["DonGia"].Value != null )
                {
                    if (IsValidDecimalNumber(dsNhap.Rows[e.RowIndex].Cells["DonGia"].Value.ToString()).ToString()=="False" || IsValidDecimalNumber(dsNhap.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()).ToString() == "False")
                    {
                        MessageBox.Show("Xin nhập số ở đơn giá và số lượng");
                        dsNhap.Refresh();
                    }
                    else 
                    { 
                    dsNhap.Rows[e.RowIndex].Cells["TongTien"].Value = Convert.ToInt32(dsNhap.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()) * Convert.ToInt32(dsNhap.Rows[e.RowIndex].Cells["DonGia"].Value.ToString());
                    }
                }   
            



            }
        }

        private bool IsValidDecimalNumber(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false; //blank/null strings aren't valid decimal numbers
            return !s.Any(c => !(char.IsDigit(c) || c == '.')) && !(s.Count(c => c == '.') > 1);
        }



    }
}
