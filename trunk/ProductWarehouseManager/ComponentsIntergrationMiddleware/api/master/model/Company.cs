using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    public sealed class Company
    {
        private int id;
        private String cid;
        private String name;
        private String description;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String CID
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
