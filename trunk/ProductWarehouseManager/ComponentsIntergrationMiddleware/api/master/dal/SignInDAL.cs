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
    class SignInDAL : GenericDAL<SignIn>
    {
        public SignInDAL(SqlHelper helper) : base(helper){}

        public SignIn login(String login, String password)
        {
            return null;
        }

        public void logout(String uid)
        {
            rawQuery(String.Format("DELETE FROM SignIn WHERE UID={0}", uid));
        }

        protected override SignIn getFromReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
