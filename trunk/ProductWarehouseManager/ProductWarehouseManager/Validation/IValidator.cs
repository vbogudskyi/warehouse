using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Validation
{
    interface IValidator
    {
        bool validation(String data);
    }
}
