using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Logistics.Common;
using Logistics.Domain;

namespace Logistics.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        //private Dictionary<Guid, T> _dictionary = new Dictionary<Guid, T>();


        //public T Insert(T obj)
        //{
        //    _dictionary.Add(new Guid(), obj);

        //    return obj;
        //}

        //public bool Delete(Guid id)
        //{
        //    return _dictionary.Remove(id);
        //}

        //public T GetById(Guid id)
        //{
        //    return _dictionary.First(x => x.Key == id).Value;
        //}

        //public IEnumerable<T> GetAll()
        //{
        //    return _dictionary.Values;
        //}

        private readonly AppContext _context;

        public GenericRepository(AppContext context)
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