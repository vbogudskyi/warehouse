using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    public sealed class SignIn
    {
        private int id;
        private String uid;
        private DateTime signInDate;
        private String ip;
        private String cookie;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String UID
        {
            get { return uid; }
            set { uid = value; }
        }

        public DateTime SignInDate
        {
            get { return signInDate; }
            set { signInDate = value; }
        }

        public String IP
        {
            get { return ip; }
            set { ip = value; }
        }

        public String Cookie
        {
            get { return cookie; }
            set { cookie = value; }
        }
    }
}
