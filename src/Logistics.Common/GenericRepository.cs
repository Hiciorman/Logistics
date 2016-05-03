using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Common
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private Dictionary<Guid, T> _dictionary = new Dictionary<Guid, T>();


        public T Insert(T obj)
        {
            _dictionary.Add(new Guid(), obj);

            return obj;
        }

        public bool Delete(Guid id)
        {
            return _dictionary.Remove(id);
        }

        public T GetById(Guid id)
        {
            return _dictionary.First(x => x.Key == id).Value;
        }

        public IEnumerable<T> GetAll()
        {
            return _dictionary.Values;
        }

    }
}