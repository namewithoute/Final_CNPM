using System.Data.SqlClient;
namespace QUANLYKHO.MODEL
{
    public class DataProvider
    {
        private const string connectStr = "Data Source=DESKTOP-9GIEK94\\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True";
        private SqlConnection cnt;

        public DataProvider()
        {
            cnt = new SqlConnection(connectStr);
        }
        public void Connect()
        {
            cnt.Open();
        }
        public void Disconnect()
        {
            cnt.Close();
        }
        public SqlDataReader ExcuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            return cmd.ExecuteReader();
        }
            
        public void ExcuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnt);
            cmd.ExecuteNonQuery();
        }
    }
}
