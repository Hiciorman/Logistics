using System;
using System.Collections.Generic;

namespace Logistics.Common
{
    public interface IGenericService<T>
    {
        T Insert(T obj);
    //    bool Update(T obj);
        bool Delete(Guid id);
    //    bool Save();

        T GetById(Guid id);
        IList<T> GetAll();
    }
}
