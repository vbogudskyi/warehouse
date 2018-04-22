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
        
        public bool validation(string data)
        {
            Regex pattern = new Regex("^(\\d{3})(?:[\\.\\-\\s]?)(\\d{3})(?:[-\\.\\s]?)(\\d{4})$");

            return pattern.IsMatch(data);
        }
    }
}
