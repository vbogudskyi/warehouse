using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Validation
{
    class PhoneValidator : IValidator
    {
        Regex pattern;
        public Boolean validation(string data)
        {
            pattern = new Regex("^(\\d{3})(?:[\\.\\-\\s]?)(\\d{3})(?:[-\\.\\s]?)(\\d{4})$");
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
