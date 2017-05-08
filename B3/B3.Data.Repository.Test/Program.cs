using System;
using B3.Data.Domain.Validation;

namespace B3.Data.Repository.Test
{
    public class Program
    {
        public static void Main()
        {
            IValidable<IcmesuyuHat> validator = new IcmesuyuHatValidator();
            
            var icmesuyu = new IcmesuyuHat();
            
            if (validator.IsValid(icmesuyu))
            {
                Console.Write("İçmesuyu hattı oluşturuldu.");
            }
            else
            {
                foreach (var brokenRule in validator.BrokenRules(icmesuyu))
                {
                    Console.WriteLine(brokenRule);
                }
            }
        }
    }
}
