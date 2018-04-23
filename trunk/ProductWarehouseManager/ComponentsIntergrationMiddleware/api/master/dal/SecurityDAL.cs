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
    class SecurityDAL : GenericDAL<Security>
    {
        public SecurityDAL(SqlHelper helper) : base(helper){}

        public List<String> getUserPermissions(String uid)
        {
            String query = String.Format("SELECT U.UID, U.RID, P.PID, P.NAME FROM SignIn SI " +
                "JOIN Users U ON (U.UID=SI.UID) " +
                "JOIN ROLE R ON (U.RID=R.RID) " +
                "JOIN RolePermissions RP ON (R.RID=RP.RID) " +
                "JOIN PERMISSIONS P ON (RP.PID=P.PID) " +
                "WHERE SI.UID='{0}'", uid);
            List<Security> data = get(query);
            return new List<String>(data.Select(d => d.PNAME));
        }

        public bool hasPermission(String uid, String permission)
        {
            List<String> permissions = getUserPermissions(uid);
            return permission.Contains(permission);
        }

        protected override Security getFromReader(SqlDataReader reader)
        {
            Security security = new Security();
            security.UID = (String)reader.GetValue(reader.GetOrdinal("UID"));
            security.RID = (int)reader.GetValue(reader.GetOrdinal("RID"));
            security.PID = (int)reader.GetValue(reader.GetOrdinal("PID"));
            security.PNAME = (String)reader.GetValue(reader.GetOrdinal("NAME"));
            return security;
        }
    }
}
