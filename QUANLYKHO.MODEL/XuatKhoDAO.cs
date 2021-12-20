using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QUANLYKHO.MODEL
{
    class XuatKhoDAO
    {
        private DataProvider provider;

        public XuatKhoDAO()
        {
            provider = new DataProvider();
        }
        public List<String> loadMaPhieuNhap()
        {
            provider.Connect();

            string sql = "SELECT MaPhieuXuat FROM PhieuXuatKho";
            SqlDataReader reader = provider.ExcuteReader(sql);

            List<String> list = new List<String>();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            provider.Disconnect();
            return list;
        }
    }
}
