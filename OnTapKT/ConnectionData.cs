using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OnTapKT
{
    public class ConnectionData
    {
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-DMI5CP2\SQLEXPRESS;Initial Catalog=QuyTrinhNhapHang;Integrated Security=True");
        }
        public DataTable CreateDataTable (string query)
        {
            SqlConnection connection = CreateConnection();
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public void excuteNonQuery (string query)
        {
            SqlConnection connection = CreateConnection();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();// giai phong bo nho
        }
        public void excuteNonQueryStoreProcedure(string sql, object[] parameter)
        {
            SqlConnection connection = CreateConnection();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            if(parameter != null)
            {
                string[] ListPara = sql.Split(' ');
                int i = 0;
                foreach(string item in ListPara)
                {
                    if(item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i] ?? (object)DBNull.Value);
                        i++;
                    }
                }
            }
            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();
        }
    }
    
    
}
