using System;
using B3.Data.Domain.Entity;

namespace B3.Data.Repository.Interfaces
{
    public interface IWriteOnlyRepository<T> where T : class, IEntity, new()
    {
        T Insert(T item);
        T Update(T item);
        T Delete(Guid id);
        T Delete(T item);
    }
}