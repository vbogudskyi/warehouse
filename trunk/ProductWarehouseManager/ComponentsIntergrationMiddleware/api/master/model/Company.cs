using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    class Company
    {
        private int id;
        private int cid;
        private String name;
        private String description;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int CID
        {
            get { return cid; }
            set { cid = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
