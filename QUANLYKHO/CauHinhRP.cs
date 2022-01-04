using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QUANLYKHO
{
    class CauHinhRP
    {
        public CauHinhRP()
        {

        }
        SqlDataAdapter dataAdapter;
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9GIEK94\SQL;Initial Catalog=QUANLYKHO;Integrated Security=True")){
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();

            }
            return dataTable;
        }

       

    }
}
