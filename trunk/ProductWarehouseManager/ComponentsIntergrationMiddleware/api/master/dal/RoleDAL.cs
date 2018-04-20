using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.dal
{
    class RoleDAL : GenericDAL<Role>
    {
        public RoleDAL(SqlHelper helper) : base(helper){}

        public void createRole(String name)
        {
            rawQuery(String.Format("INSERT INTO Role(NAME) VALUES({0})", name));
        }

        public Role getRole(String name)
        {
            return get(String.Format("SELECT * FROM Role WHERE NAME={0}", name)).FirstOrDefault();
        }

        public List<Role> getAllRoles()
        {
            return get(String.Format("SELECT * FROM Role"));
        }

        public void removeRole(int rid)
        {
            rawQuery(String.Format("DELETE FROM Role WHERE RID={0}", rid));
        }

        protected override Role getFromReader(SqlDataReader reader)
        {
            Role role = new Role();
            role.RID = (int)reader.GetValue(reader.GetOrdinal("RID"));
            role.Name = (String)reader.GetValue(reader.GetOrdinal("NAME"));
            return role;
        }
    }
}
