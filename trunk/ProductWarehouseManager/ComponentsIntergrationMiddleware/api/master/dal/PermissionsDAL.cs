using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ComponentsIntergrationMiddleware.api.master.dal
{
    class PermissionsDAL : GenericDAL<Permissions>
    {
        public PermissionsDAL(SqlHelper helper) : base(helper){}

        public void createPermission(String name)
        {
            rawQuery(String.Format("INSERT INTO Permissions(NAME) VALUES({0})", name));
        }

        public List<Permissions> getAllPermissions()
        {
            return get("SELECT * FROM Permissions");
        }

        public void deletePermission(int pid)
        {
            rawQuery(String.Format("DELETE * FROM Permissions WHERE pid={0}", pid));
        }

        protected override Permissions getFromReader(SqlDataReader reader)
        {
            Permissions permissions = new Permissions();
            permissions.PID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            permissions.Name = (String)reader.GetValue(reader.GetOrdinal("NAME"));
            return permissions;
        }
    }
}
