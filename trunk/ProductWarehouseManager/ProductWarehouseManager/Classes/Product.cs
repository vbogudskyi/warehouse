using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Classes
{
    class Product
    {
        private String date;
        private String compName;
        private String docName;
        private String prodName;
        private String prodType;
        private int prodQuantity;
        private String descritpion;

        public Product(String date, String compName, String docName, String prodName, 
                        String prodType, int prodQuantity, String descritpion)
        {
            this.date = date;
            this.compName = compName;
            this.docName = docName;
            this.prodName = prodName;
            this.prodType = prodType;
            this.prodQuantity = prodQuantity;
            this.descritpion = descritpion;
        }
        
        public String Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public String CompName
        {
            get
            {
                return compName;
            }
            set
            {
                compName = value;
            }
        }
        public String DocName
        {
            get
            {
                return docName;
            }
            set
            {
                docName = value;
            }
        }
        public String ProdName
        {
            get
            {
                return prodName;
            }
            set
            {
                prodName = value;
            }
        }
        public String ProdType
        {
            get
            {
                return prodType;
            }
            set
            {
                prodType = value;
            }
        }
        public int ProdQuantity
        {
            get
            {
                return prodQuantity;
            }
            set
            {
                prodQuantity = value;
            }
        }
        public String Description
        {
            get
            {
                return descritpion;
            }
            set
            {
                descritpion = value;
            }
        }
        public override String ToString()
        {
            return "Creation Date" + date +
                   "Company Name: " + compName +
                   "Document Name: " + docName +
                   "Product Name: " + prodName +
                   "Product Type: " + prodType +
                   "Product Quantity: " + prodQuantity +
                   "Description: " + descritpion;
        }



    }
}
