using System;
using System.Collections.Generic;


namespace Logistics.Common
{
    public interface IGenericRepository<T>
    {
        T Insert(T obj);
        bool Update(T obj);
        bool Delete(Guid id);
        void Save();
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
