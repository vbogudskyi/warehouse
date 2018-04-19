using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class ProductInventory
    {
        private int id;
        private String prId;
        private String description;
        private bool active;
        private int tid;
        private int totalQuantity;

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

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        private int TID
        {
            get { return tid; }
            set { tid = value; }
        }

        private int TotalQuantity
        {
            get { return totalQuantity; }
            set { totalQuantity = value; }
        }

    }
}
