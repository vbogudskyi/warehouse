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
    internal class InventoryDocumentationDAL : GenericDAL<InventoryDocumentation>
    {
        public InventoryDocumentationDAL(SqlHelper helper) : base(helper){}

        public void assignDocument(String uid, String docId)
        {
            rawQuery(String.Format("INSERT INTO InventoryDocumentation (UID, DocumentID) VALUES({0}, {1})",
                uid, docId));
        }

        public void changeDocumentAssignment(String uid, String docId)
        {
            rawQuery(String.Format("UPDATE InventoryDocumentation SET UID={0} " +
                "WHERE DocumentID={1}", uid, docId));
        }

        public void deleteDocumentAssignment(String uid, String docId)
        {
            rawQuery(String.Format("DELETE FROM Inventory Documntation WHERE " +
                "UID={0} AND DocumentID={1}", uid, docId));
        }

        protected override InventoryDocumentation getFromReader(SqlDataReader reader)
        {
            InventoryDocumentation documentation = new InventoryDocumentation();
            documentation.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            documentation.DocumentID = (String)reader.GetValue(reader.GetOrdinal("DocumentID"));
            documentation.UID = (String)reader.GetValue(reader.GetOrdinal("UID"));
            return documentation;
        }
    }
}
