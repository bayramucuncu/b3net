using System;
using System.Collections.Generic;
using System.Linq;
using B3.Data.Domain.Entity;
using B3.Data.Domain.Event;
using B3.Data.Domain.Validation;

namespace B3.Data.Repository.Test
{
    public class IcmesuyuHat : IEntity
    {
        public Guid Id { get; set; }
        public string Adi { get; set; }
        public int Cap { get; set; }
        public IEnumerable<IEvent> Events { get; private set; }
    }

    public class IcmesuyuHatValidator : IValidable<IcmesuyuHat>
    {
        public bool IsValid(IcmesuyuHat entity)
        {
            return !BrokenRules(entity).Any();
        }

        public IEnumerable<string> BrokenRules(IcmesuyuHat entity)
        {
            if (entity == null)
            {
                yield return "Hat nesnesi null olmamalıdır.";
                yield break;
            }
         
            if (string.IsNullOrEmpty(entity.Adi))
                yield return "Hat için bir ad girilmelidir.";
            
            if (entity.Cap <= 0)
                yield return "Hat çapı sıfır veya daha küçük olmamalıdır.";
        }
    }
}
