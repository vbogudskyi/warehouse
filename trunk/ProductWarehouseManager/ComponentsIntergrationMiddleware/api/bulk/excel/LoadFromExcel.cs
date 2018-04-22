using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.bulk.excel
{
    class LoadFromExcel
    {
        private String[] paths = null;

        public LoadFromExcel(String[] paths)
        {
            Paths = paths;
        }

        public String[] Paths
        {
            get { return paths; }
            set { paths = value; }
        }

        public List<Record> load()
        {
            List<Record> records = new List<Record>();
            using (FileStream stream = File.Open(Paths[0], FileMode.Open, FileAccess.Read))
            {
                
            }
                return records;
        }

    }
}
