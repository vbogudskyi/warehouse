using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class Security
    {
        private String uid;
        private int rid;
        private int pid;
        private String pname;

        public String UID
        {
            get { return uid; }
            set { uid = value; }
        }

        public int RID
        {
            get { return rid; }
            set { rid = value; }
        }

        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }

        public String PNAME
        {
            get { return pname; }
            set { pname = value; }
        }
    }
}
