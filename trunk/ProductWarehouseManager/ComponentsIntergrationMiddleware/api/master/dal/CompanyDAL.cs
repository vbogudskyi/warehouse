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
    class CompanyDAL : GenericDAL<Company>
    {
        public CompanyDAL(SqlHelper helper) : base(helper){}

        public void createCompany(String name, String description)
        {
            rawQuery(String.Format("INSERT INTO Company(NAME, DESCRIPTION) VALUES({0}, {1})", name, description));
        }

        public Company getCompany(String name)
        {
            return get(String.Format("SELECT * FROM Company WHERE NAME={0}", name)).FirstOrDefault();
        }

        public List<Company> getAllcompanies()
        {
            return get("SELECT * FROM Company");
        }

        public void removeCompany(String cid)
        {
            rawQuery(String.Format("DELETE * FROM Company WHERE CID={0}", cid));
        }

        protected override Company getFromReader(SqlDataReader reader)
        {
            Company company = new Company();
            company.ID = (int)reader.GetValue(reader.GetOrdinal("ID"));
            company.CID = (String)reader.GetValue(reader.GetOrdinal("CID"));
            company.Name = (String)reader.GetValue(reader.GetOrdinal("NAME"));
            company.Description = (String)reader.GetValue(reader.GetOrdinal("DESCRIPTION"));
            return company;
        }
    }
}
