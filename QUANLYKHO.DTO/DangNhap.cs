using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO.DTO
{
    public class DangNhap
    {
        private string taiKhoan, matKhau, loaiTaiKhoan, tenNhanVien, soDienThoai, diaChi;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }


        public DangNhap()
        {

        }

        public DangNhap(string taiKhoan, string matKhau, string loaiTaiKhoan, string tenNhanVien, string soDienThoai, string diaChi)
        {

            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.tenNhanVien = tenNhanVien;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }
    }
}
