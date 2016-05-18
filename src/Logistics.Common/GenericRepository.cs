using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Logistics.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public T Insert(T obj)
        {
            var result = _context.Set<T>().Add(obj);
            _context.SaveChanges();

            return result;
        }

        public bool Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;

            if (_context.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Guid id)
        {
            var toDelete = _context.Set<T>().Single(x => x.Id == id);

            if (toDelete != null)
            {
                _context.Set<T>().Remove(toDelete);
                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Single(x => x.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}