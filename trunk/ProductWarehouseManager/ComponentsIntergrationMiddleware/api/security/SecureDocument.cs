﻿using ComponentsIntergrationMiddleware.api.bulk;
using ComponentsIntergrationMiddleware.api.master.dal;
using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using System;
using System.Collections.Generic;

namespace ComponentsIntergrationMiddleware.api.security
{
    public class SecureDocument
    {
        private SystemLog logger = null;
        private SecureUser user;

        public SecureDocument(SecureUser user)
        {
            SafeUser = user;
        }

        public SecureUser SafeUser
        {
            get { return user; }
            set { user = value; }
        }

        public SystemLog Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        public void addDocument(Record document)
        {
            if(SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "INSERT"))
                    {
                        ProductInventoryDAL piDAL = new ProductInventoryDAL(helper);
                        ProductDocumentDAL pdDAL = new ProductDocumentDAL(helper);
                        ProductTypeDAL ptDAL = new ProductTypeDAL(helper);
                        InventoryDocumentationDAL idDAL = new InventoryDocumentationDAL(helper);
                        ProductType type = ptDAL.getProductType(document.ProductType);
                        if (type == null)
                        {
                            ptDAL.addProductType(document.ProductType);
                            type = ptDAL.getProductType(document.ProductType);
                        }

                        ProductInventory product = piDAL.getProduct(document.ProductName, type.TID);
                        if (product != null)
                        {
                            product.TotalQuantity += document.ProductQuantity;
                            piDAL.updateProduct(product);
                        }
                        else
                        {
                            piDAL.addProduct(type.TID, document.ProductName, document.ProductQuantity);
                            product = piDAL.getProduct(document.ProductName, type.TID);
                        }

                        ProductDocument delivery = new ProductDocument();
                        delivery.Name = document.DocumentName;
                        delivery.PrID = product.PrID;
                        delivery.Description = document.Description;
                        delivery.Quantity = document.ProductQuantity;
                        pdDAL.addDocument(delivery);

                        delivery = pdDAL.getDocument(document.DocumentName, product.PrID,
                            document.ProductQuantity, document.Description);
                        idDAL.assignDocument(SafeUser.SignIN.UID, delivery.DocumentID);
                    }
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
                
        }

        public void createInvoice(Record document)
        {
            if (SafeUser != null && SafeUser.isLoggedIn())
            {
                try
                {
                    SqlHelper helper = new SqlHelper();
                    SecurityDAL sdal = new SecurityDAL(helper);
                    if (sdal.hasPermission(SafeUser.SignIN.UID, "UPDATE") &&
                        sdal.hasPermission(SafeUser.SignIN.UID, "DELETE"))
                    {
                        ProductInventoryDAL piDAL = new ProductInventoryDAL(helper);
                        ProductDocumentDAL pdDAL = new ProductDocumentDAL(helper);
                        ProductTypeDAL ptDAL = new ProductTypeDAL(helper);
                        InventoryDocumentationDAL idDAL = new InventoryDocumentationDAL(helper);
                        ProductType type = ptDAL.getProductType(document.ProductType);
                        if (type == null)
                        {
                            ptDAL.addProductType(document.ProductType);
                            type = ptDAL.getProductType(document.ProductType);
                        }

                        ProductInventory product = piDAL.getProduct(document.ProductName, type.TID);
                        if (product != null && product.TotalQuantity - document.ProductQuantity >= 0)
                        {
                            product.TotalQuantity += document.ProductQuantity;
                            piDAL.updateProduct(product);
                        }
                        else
                        {
                            log(404, "No such product");
                            return;
                        }

                        ProductDocument delivery = new ProductDocument();
                        delivery.Name = document.DocumentName;
                        delivery.PrID = product.PrID;
                        delivery.Description = document.Description;
                        delivery.Quantity = document.ProductQuantity;
                        pdDAL.addDocument(delivery);

                        delivery = pdDAL.getDocument(document.DocumentName, product.PrID,
                            document.ProductQuantity, document.Description);
                        idDAL.assignDocument(SafeUser.SignIN.UID, delivery.DocumentID);
                    }
                }catch(Exception ex)
                {
                    log(ex);
                }
            }
        }

        public List<ProductType> getAllProductTypes()
        {
            SqlHelper helper = new SqlHelper();
            ProductTypeDAL dal = new ProductTypeDAL(helper);
            var types = dal.getAllProductType();
            helper.Close();
            return types;
        }

        private void log(Exception ex)
        {
            logger?.Invoke(ex.HResult, ex.Message);
        }

        private void log(int code, String message)
        {
            logger?.Invoke(code, message);
        }

        public delegate void SystemLog(int code, String message);
    }
}
