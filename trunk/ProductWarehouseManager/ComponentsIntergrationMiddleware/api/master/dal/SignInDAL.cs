using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using ComponentsIntergrationMiddleware.api.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.dal
{
    class SignInDAL : GenericDAL<SignIn>
    {
        public SignInDAL(SqlHelper helper) : base(helper){}

        public SignIn login(String login, String password, String rsa)
        {
            rawQuery(String.Format("INSERT INTO SignIn (UID, IP) VALUES({0}, {1})",
                String.Format("(SELECT UID FROM Users WHERE LOGIN={0} AND PSW={1} AND RSA={2})",
                login, password, rsa), NetworkUtils.getIPAddress()));
            return get(String.Format("SELECT * FROM SignIn WHERE UID={0}",
                String.Format("SELECT UID FROM Users WHERE LOGIN={0} AND PSW={1} AND RSA={2})", login, password, rsa))).FirstOrDefault();
        }

        public void logout(String uid, String cookie)
        {
            rawQuery(String.Format("DELETE FROM SignIn WHERE UID={0} AND COOKIE={1}", uid, cookie));
        }

        public bool isLoggendIn(String uid, String cookie)
        {
            SignIn logon = get(String.Format("SELECT * FROM SignIn WHERE UID={0} AND COOKIE={1}", uid, cookie)).FirstOrDefault();
            return logon != null;
        }

        protected override SignIn getFromReader(SqlDataReader reader)
        {
            SignIn signIn = new SignIn();
            signIn.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            signIn.UID = (String)reader.GetValue(reader.GetOrdinal("UID"));
            signIn.IP = (String)reader.GetValue(reader.GetOrdinal("IP"));
            signIn.Cookie = (String)reader.GetValue(reader.GetOrdinal("Cookie"));
            return signIn;
        }
    }
}
