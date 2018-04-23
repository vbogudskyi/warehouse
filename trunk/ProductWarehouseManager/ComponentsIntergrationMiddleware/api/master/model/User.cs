using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    public sealed class User
    {
        private int id;
        private String uid;
        private int rid;
        private String lname;
        private String fname;
        private String rsa;
        private String login;
        private String telephone;
        private String companyID;
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
            get { return lname; }
            set { lname = value; }
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

        public String TELEPHONE
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public bool ACTIVE
        {
            get { return active; }
            set { active = value; }
        }

        public String CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
    }
}
