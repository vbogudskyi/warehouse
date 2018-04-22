using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.bulk
{
    public sealed class Record
    {
        private String creationDate;
        private String companyName;
        private String documentName;
        private String productName;
        private String productType;
        private int productQuantity;
        private String description;

        public String CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }

        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public String DocumentName
        {
            get { return documentName; }
            set { documentName = value; }
        }

        public String ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public String ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }




    }
}
