using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B3.Data.Domain;

namespace B3.Data.Repository.Interfaces
{
    public interface IReadOnlyRepositoryAsync<T> where T: class , IEntity, new()
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
    }
}