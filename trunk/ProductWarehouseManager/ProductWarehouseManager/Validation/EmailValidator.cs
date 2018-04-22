using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Validation
{
    class EmailValidator : IValidator
    {
         
        public bool validation(string data)
        {
            Regex pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            return pattern.IsMatch(data);
        }


    }
}
