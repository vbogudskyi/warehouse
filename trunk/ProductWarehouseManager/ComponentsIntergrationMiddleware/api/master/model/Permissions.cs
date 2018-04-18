using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class Permissions
    {
        private int pid;
        private String name;

        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
