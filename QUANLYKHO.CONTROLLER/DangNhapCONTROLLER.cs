using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYKHO.MODEL;
using QUANLYKHO.DTO;
namespace QUANLYKHO.CONTROLLER
{
    public class DangNhapCONTROLLER
    {
        private DangNhapDAO dangNhapDao;

        public DangNhapCONTROLLER()
        {
            dangNhapDao = new DangNhapDAO();
        }
        public DangNhap findUser(string taikhoan,string matkhau)
        {
            return dangNhapDao.findUser(taikhoan, matkhau);
        }
    }

}
