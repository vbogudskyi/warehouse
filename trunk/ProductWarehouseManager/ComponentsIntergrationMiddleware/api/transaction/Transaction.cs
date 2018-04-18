using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.transaction
{
    abstract class Transaction
    {
        protected abstract void execute();
        protected abstract void cancel();
    }
}
