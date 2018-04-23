using System;
using System.Data.SqlClient;

namespace ComponentsIntergrationMiddleware.api.master.helper
{
    class SqlHelper
    {
        SqlConnection connection = null;
        public SqlHelper()
        {
            connection = new SqlConnection(@"Data Source=NICOLAE-PC\MYSQLSERVER;Initial Catalog=ProductWarehouse;Integrated Security=True");
        }

        public void rawQuery(String sql)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=NICOLAE-PC\MYSQLSERVER;Initial Catalog=ProductWarehouse;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader execSql(String sql)
        {
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            reader = command.ExecuteReader();
            return reader;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
