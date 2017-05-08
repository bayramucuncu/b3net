using System.Collections.Generic;
using B3.Data.Domain.Entity;

namespace B3.Data.Domain.Validation
{
    public interface IValidable<in TEntity> where TEntity: IEntity
    {
        bool IsValid(TEntity entity);
        IEnumerable<string> BrokenRules(TEntity entity);
    }
}