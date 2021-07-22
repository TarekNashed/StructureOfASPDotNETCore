using DependencyInjection.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Models.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public readonly ApplicationDBContext _applicationDBContext;
        public DbSet<T> _entities { get; set; }
        public GenericRepository(ApplicationDBContext dBContext)
        {
            _applicationDBContext = dBContext;
            _entities = _applicationDBContext.Set<T>();
        }
        public void Add(T obj)
        {
            _entities.Add(obj);
         //   _applicationDBContext.SaveChanges();
        }
        public void Delete(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("entity");
            _entities.Remove(obj);
          //  _applicationDBContext.SaveChanges();
        }

        public T get(int id)
        {
            if (id == 0)
                throw new ArgumentNullException("entity");
            return _entities.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable<T>();
        }

        public void Update(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("entity");
            _entities.Update(obj);
         //   _applicationDBContext.SaveChanges();
        }
    }
}
