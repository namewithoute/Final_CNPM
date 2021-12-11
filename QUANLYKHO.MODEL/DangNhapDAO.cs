using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYKHO.DTO;
namespace QUANLYKHO.MODEL
{
    public class DangNhapDAO
    {
        private DataProvider provider;
        public DangNhapDAO()
        {
            provider = new DataProvider();
        }
        public DangNhap findUser(string taiKhoan,string matKhau)
        {
            provider.Connect();
            String sql = "SELECT * FROM Account where TaiKhoan ='" + taiKhoan + "' and MatKhau = '" + matKhau+"'" ;
            SqlDataReader reader = provider.ExcuteReader(sql);
            DangNhap user = null;
            if (reader.Read()==true)
            {
                user = new DangNhap(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));

            }
            return user;
        }

    }
}
