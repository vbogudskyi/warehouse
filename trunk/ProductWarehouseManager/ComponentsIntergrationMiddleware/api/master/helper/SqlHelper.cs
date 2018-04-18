using System;
using System.Data.SqlClient;

namespace ComponentsIntergrationMiddleware.api.master.helper
{
    class SqlHelper
    {
        public SqlHelper(){}

        public void rawQuery(String sql)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LSDEIQP\SQLEXPRESS;Initial Catalog=ProductWarehouse;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader execSql(String sql)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-LSDEIQP\SQLEXPRESS;Initial Catalog=ProductWarehouse;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(sql, connection)){

                    return command.ExecuteReader();
                }
            }
        }
    }
}
