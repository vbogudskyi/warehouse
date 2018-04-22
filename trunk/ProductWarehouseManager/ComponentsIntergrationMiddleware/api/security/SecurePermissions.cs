using ComponentsIntergrationMiddleware.api.master.dal;
using ComponentsIntergrationMiddleware.api.master.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.security
{
    public class SecurePermissions
    {
        private SecureUser user;
        private SystemLog logger = null;

        public SecurePermissions(SecureUser user)
        {
            SafeUser = user;
        }

        public SecureUser SafeUser
        {
            get { return user; }
            set { user = value; }
        }

        public SystemLog Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        public void grantPermissionForRole(int rid, int pid)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {

                        RolePermissionsDAL dal = new RolePermissionsDAL(helper);
                        dal.grantPermission(rid, pid);
                        log(200, "Permissions are successfully granted");
                    }else
                    {
                        log(600, "(SP) Permission denied");
                    }
                } catch(Exception ex)
                {
                    log(ex);
                }
            }
        }

        public void revokePermissions(int rid, int pid)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {
                        RolePermissionsDAL dal = new RolePermissionsDAL(helper);
                        dal.revokePermission(rid, pid);
                        log(200, "A permission is succesfully revoked");
                    }else
                    {
                        log(600, "(SP) Permission denied");
                    }
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
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
