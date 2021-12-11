using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QUANLYKHO.DTO;


namespace QUANLYKHO.MODEL

{
    public class NhapKhoDAO
    {
        private DataProvider provider;

        public NhapKhoDAO()
        {
            provider = new DataProvider();
        }

        public List<PhieuNhapKho> LoadAll(string maphieu)
        {
            provider.Connect();

            string sql = "SELECT MaSanPham, TenSanPham, SoLuong, DonGia, TongTien FROM PhieuNhapHang where MaPhieuNhap ='"+maphieu+"'";
            SqlDataReader reader = provider.ExcuteReader(sql);

            List<PhieuNhapKho> list = new List<PhieuNhapKho>();
            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string tenSanPham = reader.GetString(1);
                int soLuong = reader.GetInt32(2);
                int donGia = reader.GetInt32(3);
                int tongTien = reader.GetInt32(4);

                PhieuNhapKho pnk = new PhieuNhapKho( maSanPham, tenSanPham, soLuong, donGia, tongTien);
                list.Add(pnk);
            }
            provider.Disconnect();
            return list;
        }
        public List<String> loadMaPhieuNhap()
        {
            provider.Connect();

            string sql = "SELECT MaPhieuNhap FROM PhieuNhapHang";
            SqlDataReader reader = provider.ExcuteReader(sql);

            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            provider.Disconnect();
            return list;
        }
        public String getName(String maphieunhap)
        {
            provider.Connect();

            string sql = "SELECT TenNhanVien FROM PhieuNhapHang where MaPhieuNhap = '"+ maphieunhap+"'";
            SqlDataReader reader = provider.ExcuteReader(sql);
            string name = "";
            if (reader.Read() == true)
            {
                name = reader.GetString(0);

            }
            
            provider.Disconnect();
            return name;
        }
        public void xoaPhieuNhap(String maphieuxoa)
        {
            provider.Connect();
            string sql = "DELETE FROM PhieuNhapHang WHERE MaPhieuNhap = '"+maphieuxoa+"'";
            provider.ExcuteQuery(sql);
            provider.Disconnect();
        }


    }
}
    
