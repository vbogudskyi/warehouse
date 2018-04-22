using ComponentsIntergrationMiddleware.api.master.helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.dal
{
    abstract class GenericDAL<T>
    {
        private SqlHelper helper = null;

        public GenericDAL(SqlHelper helper)
        {
            this.helper = helper;
        }

        protected abstract T getFromReader(SqlDataReader reader);

        public void rawQuery(String sql)
        {
            helper.rawQuery(sql);
        }

        public List<T> get(String sql)
        {
            List<T> items = new List<T>();
            SqlDataReader reader = helper.execSql(sql);
            if(reader != null)
            {
                while (reader.Read())
                {
                    items.Add(getFromReader(reader));
                }
            }
            reader.Close();
            return items;
        }
    }
}
