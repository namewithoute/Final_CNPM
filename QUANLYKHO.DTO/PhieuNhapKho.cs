using System;


namespace QUANLYKHO.DTO
{
    public class PhieuNhapKho
    {
        private String maSanPham, tenSanPham;
        private int soLuong, tongTien, donGia;

       
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int DonGia { get => donGia; set => donGia = value; }



        public PhieuNhapKho()
        {

        }

        
        public PhieuNhapKho(string maSanPham, string tenSanPham, int soLuong, int donGia, int tongTien)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tongTien = tongTien;
        }
    } 
}
