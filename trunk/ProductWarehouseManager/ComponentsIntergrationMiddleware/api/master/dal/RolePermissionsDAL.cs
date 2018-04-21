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
    class RolePermissionsDAL : GenericDAL<RolePermission>
    {
        public RolePermissionsDAL(SqlHelper helper) : base(helper) {}

        public void grantPermission(int rid, int pid)
        {
            rawQuery(String.Format("INSERT INTO RolePermissions(RID, PID) VALUES({0},{1})", rid, pid));
        }

        public void revokePermission(int rid, int pid)
        {
            rawQuery(String.Format("DELETE FROM RolePermissions WHERE RID={0} AND PID={0}", rid, pid));
        }

        protected override RolePermission getFromReader(SqlDataReader reader)
        {
            RolePermission rp = new RolePermission();
            rp.RPID = (int)reader.GetValue(reader.GetOrdinal("RPID"));
            rp.RID = (int)reader.GetValue(reader.GetOrdinal("RID"));
            rp.PID = (int)reader.GetValue(reader.GetOrdinal("PID"));
            return rp;
        }
    }
}
