using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.model
{
    sealed class InventoryDocumentation
    {
        private int id;
        private String uid;
        private String documentId;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String UID
        {
            get { return uid; }
            set { uid = value; }
        }

        public String DocumentID
        {
            get { return documentId; }
            set { documentId = value; }
        }
    }
}
