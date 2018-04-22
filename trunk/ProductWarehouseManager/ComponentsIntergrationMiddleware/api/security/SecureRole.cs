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
    public class SecureRole
    {
        private SecureUser user = null;
        private SystemLog logger = null;

        public SecureRole(SecureUser user)
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
            get{ return logger; }
            set { logger = value; }
        }

        public void createRole(String name)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {
                        RoleDAL dal = new RoleDAL(helper);
                        dal.createRole(name);
                        log(200, "Role is created successfully");
                    }else
                    {
                        log(600, "(SR) Permission denied");
                    }
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
        }

        public void deleteRole(int rid)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {
                        RoleDAL dal = new RoleDAL(helper);
                        dal.removeRole(rid);
                        log(200, "Role is removed successfully");
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

        public Role getUserRole(String uid)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {
                        RoleDAL dal = new RoleDAL(helper);
                        log(200, "A role is successfully got");
                        return dal.getUserRole(uid);
                    }
                    else
                    {
                        log(600, "Permission denied");
                    }
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
            return null;
        }

        public List<Role> getAllRoles()
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "USER"))
                    {
                        RoleDAL dal = new RoleDAL(new SqlHelper());
                        return dal.getAllRoles();
                    }
                    else
                    {
                        log(600, "(SP) Permission denied");
                    }
                }catch(Exception ex)
                {
                    log(ex);
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
