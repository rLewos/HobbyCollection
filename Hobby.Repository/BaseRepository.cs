using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Repository
{
	public abstract class BaseRepository<T> : IBaseRepository<T>
	{
		public void Add(T entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public T Get(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
