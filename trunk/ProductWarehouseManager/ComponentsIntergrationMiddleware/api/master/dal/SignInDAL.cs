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
            String query = String.Format("INSERT INTO SignIn (UID, IP) VALUES({0}, '{1}')",
                String.Format("(SELECT UID FROM Users WHERE LOGIN='{0}' AND PSW='{1}' AND RSA='{2}')",
                login, password, rsa.Replace("\r\n", String.Empty)), NetworkUtils.getIPAddress());
            rawQuery(query);

            String query2 = String.Format("SELECT * FROM SignIn WHERE UID={0}",
                            String.Format("(SELECT UID FROM Users WHERE LOGIN='{0}' AND PSW='{1}' AND RSA='{2}')", login, password, rsa.Replace("\r\n", String.Empty)));
            return get(query2).FirstOrDefault();
        }

        public SignIn logout(String uid, String cookie)
        {
            String query = String.Format("DELETE FROM SignIn WHERE UID='{0}' AND COOKIE='{1}'", uid, cookie);
            rawQuery(query); 
            return null;
        }

        public bool isLoggedIn(String uid, String cookie)
        {

            SignIn logon = get(String.Format("SELECT * FROM SignIn WHERE UID='{0}' AND COOKIE='{1}'", uid, cookie)).FirstOrDefault();
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
