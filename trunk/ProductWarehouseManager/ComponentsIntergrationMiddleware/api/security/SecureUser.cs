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
    public class SecureUser
    {
        private SignIn signIn = null;
        private SystemLog logger = null;

        public SignIn SignIN
        {
            get { return signIn; }
            set { signIn = value; }
        }

        public SystemLog Logger
        {
            set { logger = value; }
        }

        public void createUser(String login, String password,
                               String firstName, String lastName,
                               String telephone, String rsa,
                               bool active = true, String company = null)
        {
            try
            {
                UserDAL dal = new UserDAL(new SqlHelper());
                dal.createUser(login, password, firstName, lastName, telephone, rsa,
                    active, company);
                log(200, "User created successfully");
            }catch(Exception ex)
            {
                log(ex);
            }
        }

        public void updateUser(String uid, String login, String password,
                               String firstName, String lastName,
                               String rsa, bool active = true,
                               String role = null, String company = null)
        {
            if (isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(signIn.UID, "USER"))
                    {
                        UserDAL dal = new UserDAL(helper);
                        dal.updateUser(uid, login, password, firstName, lastName,
                            rsa, active, role, company);
                        log(200, "Update is successfull");
                    }
                    else
                    {
                        log(600, "(PW)Permission denied");
                    }
                }
                catch (Exception ex)
                {
                    log(ex);
                }
            }
        }

        public void deleteUser(String uid)
        {
            if (isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SignIN.UID, "USER"))
                    {
                        UserDAL dal = new UserDAL(helper);
                        dal.removeUser(uid);
                    }
                    else
                    {
                        log(600, "(PW)Permission denied");
                    }
                }
                catch (Exception ex)
                {
                    log(ex);
                }
            }
     
        }

        public void login(String email, String psw, String rsa)
        {
            if(SignIN == null)
            {
                try
                {
                    SignInDAL dal = new SignInDAL(new SqlHelper());
                    SignIN = dal.login(email, psw, rsa);
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
            else
            {
                log(400, "You are already logged in");
            }
        }

        public void logout()
        {
            if(!isLoggedIn())
            {
                try
                {
                    SignInDAL dal = new SignInDAL(new SqlHelper());
                    SignIN = dal.logout(SignIN.UID, SignIN.Cookie);
                }catch(Exception ex)
                {
                    log(ex);
                }
            }else
            {
                log(400, "You are already logged out");

            }
        }

        public bool isLoggedIn()
        {
            if(SignIN != null)
            {
                if(SignIN.Cookie != null)
                {
                    try
                    {
                        SignInDAL dal = new SignInDAL(new SqlHelper());
                        return dal.isLoggedIn(SignIN.UID, SignIN.Cookie);
                    }catch(Exception ex)
                    {
                        log(ex);
                    }
                }
                else
                {
                    log(530, "Cookies are not valid. Please re-login");
                }
            }
            else
            {
                log(500, "You must be logged in to perform an operation");
            }

            return false;
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
