using Games.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Service
{
    public abstract class BaseService<T> : IBaseService<T>
    {
        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public T Get(int codObj)
        {
            throw new NotImplementedException();
        }

        public void Save(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public T Validate(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
