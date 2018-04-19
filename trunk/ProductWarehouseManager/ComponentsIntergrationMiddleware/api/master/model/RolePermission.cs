using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class RolePermission
    {
        private int rpid;
        private int rid;
        private int pid;

        public int RPID
        {
            get { return rpid; }
            set { rpid = value; }
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
    }
}
