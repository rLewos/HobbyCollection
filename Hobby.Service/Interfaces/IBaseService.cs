using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Service.Interfaces
{
    public interface IBaseService<T>
    {
        public void Save(T obj);
        public void Update(T obj);
        public void Delete(T obj);
        public T Get(int codObj);
        public T Validate(T t);
    }
}
