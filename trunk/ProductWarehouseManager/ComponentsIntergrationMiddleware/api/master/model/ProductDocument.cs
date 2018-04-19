using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class ProductDocument
    {
        private int id;
        private String documentId;
        private String name;
        private String prId;
        private int quantity;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String DocumentID
        {
            get { return documentId; }
            set { documentId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String PrID
        {
            get { return prId; }
            set { prId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
