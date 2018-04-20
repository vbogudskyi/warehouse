using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Validation
{
    class ValidatorContext
    {
        private IValidator validate;

        public Boolean SetValidation(IValidator validate)
        {
            this.validate = validate;
            return true;
        }
    }
}
