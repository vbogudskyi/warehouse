using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.transaction
{
    interface ITransaction<T>
    {
          T execute();
        void cancel();
    }
}
