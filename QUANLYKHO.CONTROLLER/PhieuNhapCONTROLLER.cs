using QUANLYKHO.MODEL;
using QUANLYKHO.DTO;
using System;
using System.Collections.Generic;

namespace QUANLYKHO.CONTROLLER
{
    public class PhieuNhapCONTROLLER
    {
        private NhapKhoDAO nhapKhoDao;

        public PhieuNhapCONTROLLER()
        {
            nhapKhoDao = new NhapKhoDAO();
        }
        public List<PhieuNhapKho> loadAll(String maphieu)
        {
            return nhapKhoDao.LoadAll(maphieu);
        }
        public List<String> loadMaPhieuNhap()
        {
            return nhapKhoDao.loadMaPhieuNhap();
        }

        public String getName(String maphieunhap)
        {
            return nhapKhoDao.getName(maphieunhap);
        }
        public void xoaPhieuNhap(String maphieuxoa)
        {
            nhapKhoDao.xoaPhieuNhap(maphieuxoa);
        }

    }
}
