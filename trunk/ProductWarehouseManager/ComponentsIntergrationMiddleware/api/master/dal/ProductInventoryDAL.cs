using ComponentsIntergrationMiddleware.api.master.helper;
using ComponentsIntergrationMiddleware.api.master.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.master.dal
{
    class ProductInventoryDAL : GenericDAL<ProductInventory>
    {
        public ProductInventoryDAL(SqlHelper helper) : base(helper){}

        public void addProduct(int tid, String name, int quantity)
        {
            rawQuery(String.Format("INSERT INTO ProductInventory(TID, Name, TotalQuantity) VALUES( " +
                "{0}, '{1}',{2})", tid, name, quantity));
        }

        public ProductInventory getProduct(String name, int tid)
        {
            String query = String.Format("SELECT * FROM ProductInventory PI " +
                "JOIN ProductType PT ON (PI.TID=PT.TID) " +
                "WHERE Name='{0}' AND TID={1} ", name, tid);
            return get(query).FirstOrDefault();
        }

        public void updateProduct(ProductInventory product)
        {
            String query = String.Format("UPDATE ProductInventory SET " +
                "TID={0}, Name='{1}', TotalQuantity={3}, " +
                "WHERE PrID='{4}'", product.TID, product.Name, product.TotalQuantity);
            rawQuery(query);
        }

        public void deleteProduct(String prID)
        {
            rawQuery(String.Format("DELETE FROM ProductInventory WHERE prID='{0}'", prID));
        }

        protected override ProductInventory getFromReader(SqlDataReader reader)
        {
            ProductInventory inventory = new ProductInventory();
            inventory.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            inventory.Active = ((int)reader.GetValue(reader.GetOrdinal("ID"))) == 1;
            inventory.Name = (String)reader.GetValue(reader.GetOrdinal("Name"));
            inventory.PrID = (String)reader.GetValue(reader.GetOrdinal("PrID"));
            inventory.TID = (int)reader.GetValue(reader.GetOrdinal("TID"));
            inventory.TotalQuantity = (int)reader.GetValue(reader.GetOrdinal("TotalQuantity"));
            return inventory;
        }
    }
}
