using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Service.Interfaces
{
    public interface IBaseService<T>
    {
        void Save(T obj);
        T? GetById(int id);
        void Remove(int id);
    }
}
