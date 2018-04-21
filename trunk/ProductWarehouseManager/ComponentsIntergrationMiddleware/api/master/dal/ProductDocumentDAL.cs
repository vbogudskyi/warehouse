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
    class ProductDocumentDAL : GenericDAL<ProductDocument>
    {
        public ProductDocumentDAL(SqlHelper helper) : base(helper) {}

        protected override ProductDocument getFromReader(SqlDataReader reader)
        {
            ProductDocument document = new ProductDocument();
            document.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            document.DocumentID = (String)reader.GetValue(reader.GetOrdinal("DocumentID"));
            document.Name = (String)reader.GetValue(reader.GetOrdinal("Name"));
            document.PrID = (String)reader.GetValue(reader.GetOrdinal("PrID"));
            document.Description = (String)reader.GetValue(reader.GetOrdinal("Description"));
            document.Quantity = (int)reader.GetValue(reader.GetOrdinal("Quantity"));
            return document;
        }
    }
}
