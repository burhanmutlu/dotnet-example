using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Context.Repositories
{
	public class GenericRepository<T>:IGenericDal<T> where T : class
	{
		private readonly ProjectContext _projectContext;

		public GenericRepository(ProjectContext projectContext)
		{
			_projectContext = projectContext;
		}

		public void Delete(T entity)
		{
			_projectContext.Remove(entity);
			_projectContext.SaveChanges();
		}

		public List<T> GetAll()
		{
			return _projectContext.Set<T>().ToList();
		}

		public T GetByID(int id) 
		{
			return _projectContext.Set<T>().Find(id);
		}

		public void Insert(T entity) 
		{ 
			_projectContext.Add(entity);
			_projectContext.SaveChanges();
		}

		public void Update(T entity) 
		{ 
			_projectContext.Update(entity);
			_projectContext.SaveChanges();
		}
	}
}
