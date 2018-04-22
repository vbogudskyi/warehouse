using ComponentsIntergrationMiddleware.api.master.dal;
using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.security
{
    public class SecureCompany
    {
        private SystemLog logger = null;
        private SecureUser user;

        public SecureCompany(SecureUser user)
        {
            SafeUser = user;
        }

        public SystemLog Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        public SecureUser SafeUser
        {
            get { return user; }
            set { user = value; }
        }

        public List<Company> getAllCompanies()
        {
            if (SafeUser != null && SafeUser.isLoggedIn())
            {
                SqlHelper helper = new SqlHelper();
                SecurityDAL sdal = new SecurityDAL(helper);
                if (sdal.hasPermission(SafeUser.SignIN.UID, "SELECT"))
                {
                    CompanyDAL dal = new CompanyDAL(helper);
                    return dal.getAllcompanies(); 
                }
            }

            return null;
        
        }

        private void log(Exception ex)
        {
            logger?.Invoke(ex.HResult, ex.Message);
        }

        private void log(int code, String message)
        {
            logger?.Invoke(code, message);
        }

        public delegate void SystemLog(int code, String message);
    }
}
