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
    class ProductTypeDAL : GenericDAL<ProductType>
    {
        public ProductTypeDAL(SqlHelper helper) : base(helper) {}

        public void addProductType(String name)
        {
            rawQuery(String.Format("INSERT INTO ProductType VALUES({0})", name));
        }

        public ProductType getProductType(int tid)
        {
            return get(String.Format("SELECT * FROM ProductType WHERE TID={0}", tid)).FirstOrDefault();
        }

        public List<ProductType> getAllProductType()
        {
            return get("SELECT * FROM ProductType");
        }

        public void deleteProductType(int tid)
        {
            rawQuery(String.Format("DELETE FROM ProductType WHERE TID={0}", tid));
        }

        protected override ProductType getFromReader(SqlDataReader reader)
        {
            ProductType type = new ProductType();
            type.TID = (int)reader.GetValue(reader.GetOrdinal("TID"));
            type.Name = (String)reader.GetValue(reader.GetOrdinal("Name"));
            return type;
        }
    }
}
