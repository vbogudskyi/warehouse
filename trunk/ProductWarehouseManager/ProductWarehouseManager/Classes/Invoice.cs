using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Classes
{
    class Invoice
    {
        private String invoiceDate;
        private String productName;
        private String productType;
        private int quantity;
        private String description;

        public Invoice(string invoiceDate, string productName, string productType, int quantity, string description)
        {
            this.invoiceDate = invoiceDate;
            this.productName = productName;
            this.productType = productType;
            this.quantity = quantity;
            this.description = description;
        }

        public String InvoiceDate
        {
            get
            {
                return invoiceDate;
            }
            set
            {
                invoiceDate = value;
            }
        }
        public String ProductNmae
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public String ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }


        public override string ToString()
        {
            return "Invoice Date: " + invoiceDate +
                   "Product Name: " + productName +
                   "Product Type: " + productType +
                   "Product Quantity: " + quantity +
                   "Description: " + description;
        }
    }
}
