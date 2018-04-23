using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    public sealed class ProductType
    {
        private int tid;
        private String name;

        public int TID
        {
            get { return tid; }
            set { tid = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
