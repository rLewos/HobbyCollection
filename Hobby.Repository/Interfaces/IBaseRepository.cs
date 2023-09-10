using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Repository.Interfaces
{
	public interface IBaseRepository<T>
	{
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		T Get(int id);
	}
}
