using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Classes
{
    class ReadRSA
    {
        String file;
        String data;

        public ReadRSA(String file)
        {
            this.file = file;
        }

        public String File
        {
            get
            {
                return file;
            }
            set
            {
                this.file = value;
            }
        }

        public String readRsa()
        {
            StreamReader streamReader = new StreamReader(file);
            String data1 = null;

         //   if (streamReader.ReadLine() == "-----BEGIN PUBLIC KEY-----") ;

         //   {

                    data = streamReader.ReadToEnd();
            data = data.Replace("-----BEGIN PUBLIC KEY-----", "");
            data = data.Replace("-----END PUBLIC KEY-----", "");

        //    }
           // Console.WriteLine(data);
            return data.Trim();
          
        }


    }
}
