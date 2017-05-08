using System;
using System.Threading.Tasks;
using B3.Data.Domain.Entity;

namespace B3.Data.Repository.Interfaces
{
    public interface IWriteOnlyRepositoryAsync<T> where T : class, IEntity, new()
    {
        Task<T> Insert(T item);
        Task<T> Update(T item);
        Task<T> Delete(Guid id);
        Task<T> Delete(T item);
    }
}