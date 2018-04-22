using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    public sealed class ProductInventory
    {
        private int id;
        private String prId;
        private bool active;
        private int tid;
        private int totalQuantity;
        private String name;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String PrID
        {
            get { return prId; }
            set { prId = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int TID
        {
            get { return tid; }
            set { tid = value; }
        }

        public int TotalQuantity
        {
            get { return totalQuantity; }
            set { totalQuantity = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
