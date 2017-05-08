using System;
using System.Collections.Generic;
using B3.Data.Domain.Entity;

namespace B3.Data.Repository.Interfaces
{
    public interface IReadOnlyRepository<out T> where T: class , IEntity, new()
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}