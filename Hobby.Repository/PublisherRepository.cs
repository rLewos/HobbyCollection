﻿using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Repository
{
	public class PublisherRepository : IBaseRepository<Publisher>, IPublisherRepository
	{
		private HobbyContext _context;

		public PublisherRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Add(Publisher entity)
		{
			try
			{
				_context.Publishers.Add(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void Delete(Publisher entity)
		{
			try
			{
				_context.Publishers.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Publisher Get(int id)
		{
			return _context.Publishers.SingleOrDefault(p => p.Id == id);
		}

		public Publisher GetByName(string publisherName)
		{
			return _context.Publishers.SingleOrDefault(p => p.Name == publisherName);
		}

		public IList<Publisher> ListAll()
		{
			return _context.Publishers.ToList();
		}

		public void Update(Publisher entity)
		{
			throw new NotImplementedException();
		}
	}
}
