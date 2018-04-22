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
    class UserDAL : GenericDAL<User>
    {
        public UserDAL(SqlHelper helper) : base(helper){}

        public void createUser(String login, String password,
                               String firstName, String lastName, String telephone,
                               String rsa, bool active = true,
                               String company = null
                              )
        {
            String query = String.Format("INSERT INTO Users (LOGIN, PSW, FNAME, LNAME, RSA, ACTIVE, CID, TELEPHONE) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', " +
                "'{5}', {6}, {7}, '{8}')", login, password, firstName, lastName, rsa, active ? 1 : 0,
                String.Format("(SELECT CID FROM COMPANY WHERE NAME={0}) ", company ?? "Common Company"), telephone);
            rawQuery(query);
        }

        public void updateUser(String uid, String login, String password,
                               String firstName, String lastName,
                               String rsa, bool active = true,
                               String role = null, String company = null)
        {
            String query = "UPDATE Users SET " +
                String.Format("LOGIN='{0}', ", login) +
                String.Format("PSW='{0}', ", password) +
                String.Format("FNAME='{0}', ", firstName) +
                String.Format("LNAME='{0}', ", lastName) +
                String.Format("ACTIVE={0}, ", active ? 1 : 0) +
                String.Format("RSA='{0}' ", rsa) +
                String.Format("RID={0}, ", String.Format("(SELECT RID FROM ROLE WHERE NAME={0}) ", role ?? "Admin")) +
                String.Format("CID={0}, ", String.Format("(SELECT CID FROM COMPANY WHERE NAME={0}) ", company ?? "Common Company") +
                String.Format("WHERE UID='{0}' ", uid)
           );
            rawQuery(query);
        }

        public User getUser(String uid)
        {
            return get(String.Format("SELECT * FROM Users WHERE UID={0}", uid)).FirstOrDefault();
        }

        public List<User> getAllUsers()
        {
            return get("SELECT * FROM Users");
        }

        public void removeUser(String uid)
        {
            rawQuery(String.Format("DELETE FROM Users WHERE UID={0}", uid));
        }

        protected override User getFromReader(SqlDataReader reader)
        {
            User user = new User();
            user.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            user.UID = (String)reader.GetValue(reader.GetOrdinal("UID"));
            user.RID = (int)reader.GetValue(reader.GetOrdinal("RID"));
            user.LNAME = (String)reader.GetValue(reader.GetOrdinal("LNAME"));
            user.FNAME = (String)reader.GetValue(reader.GetOrdinal("FNAME"));
            user.LOGIN = (String)reader.GetValue(reader.GetOrdinal("LOGIN"));
            user.ACTIVE = ((int)reader.GetValue(reader.GetOrdinal("ACTIVE"))) == 1;
            user.CompanyID = (int)reader.GetValue(reader.GetOrdinal("CID"));
            return user;
        }
    }
}
