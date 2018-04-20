using ComponentsIntergrationMiddleware.api.master.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsIntergrationMiddleware.api.transaction
{
    class Transaction<T> : ITransaction<T>
    {
        private GenericDAL<T> dal;

        public void cancel()
        {
            throw new NotImplementedException();
        }

        public T execute()
        {
            throw new NotImplementedException();
        }
    }
}
