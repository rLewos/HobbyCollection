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
        public T? GetById(int id);
        public void Remove(int id);
    }
}
