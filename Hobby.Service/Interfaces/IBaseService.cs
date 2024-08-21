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
        public void Delete(int id);
        public T? GetById(int id);
        public void Validate(T type);
    }
}
