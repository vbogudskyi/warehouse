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
