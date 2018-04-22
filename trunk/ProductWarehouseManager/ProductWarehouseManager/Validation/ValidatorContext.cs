using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWarehouseManager.Validation
{
    class ValidatorContext : IValidator
    {
        private IValidator validate;

        public ValidatorContext(IValidator validate)
        {
            this.validate = validate;
        }

        public bool validation(string data)
        {
            return validate.validation(data);
        }

    }
}
