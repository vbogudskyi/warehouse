using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class User
    {
        private int id;
        private String uid;
        private int rid;
        private String lname;
        private String fname;
        private String rsa;
        private String login;
        private int companyID;
        private bool active;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String UID
        {
            get { return uid; }
            set{ uid = value; }
        }

        public int RID
        {
            get { return rid; }
            set { rid = value; }
        }

        public String FNAME
        {
            get { return fname; }
            set { fname = value; }
        }

        public String LNAME
        {
            get { return uid; }
            set { uid = value; }
        }

        public String RSA
        {
            get { return rsa; }
            set { rsa = value; }
        }

        public String LOGIN
        {
            get { return login; }
            set { login = value; }
        }

        public bool ACTIVE
        {
            get { return active; }
            set { active = value; }
        }

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
    }
}
