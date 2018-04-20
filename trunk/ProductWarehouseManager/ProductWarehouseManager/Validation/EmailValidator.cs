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
        Regex pattern;
        public Boolean validation(string data)
        {
            pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (pattern.IsMatch(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
