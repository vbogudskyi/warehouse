using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class Role
    {
        private int rid;
        private String name;

        public int RID
        {
            get { return rid; }
            set { rid = value; }
        }

        public String Name
        {
            get { return name; }
        }
    }
}
