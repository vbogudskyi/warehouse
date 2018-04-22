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

        public void addDocument(ProductDocument document)
        {
            rawQuery(String.Format("INSERT INTO ProductDocument (Name, PrID, Quantity, Description) VALUES ( " +
                "'{0}', {1}, {2}, '{3}'", document.Name, document.PrID, document.Quantity, document.Description));
        }

        public ProductDocument getDocument(String documentID)
        {
            return get(String.Format("SELECT * FROM ProductDocument WHERE DocumentID='{0}'", documentID)).FirstOrDefault();
        }

        public ProductDocument getDocument(String name, String prID, int quantity, String description)
        {
            String query = String.Format("SELECT * FROM ProductDocument " +
                "WHERE Name='{0}', PrID={1}, Quantity={2}, Description='{3}'", 
                name, prID, quantity, description);
            return get(query).FirstOrDefault();
        }

        public void removeDocument(String documentId)
        {
            rawQuery(String.Format("DELETE FROM ProductDocument WHERE DocumentID='{0}'", documentId));
        }

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
