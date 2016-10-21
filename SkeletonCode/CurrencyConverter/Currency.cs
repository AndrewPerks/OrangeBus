using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CurrencyConverter
{
    
    public class Currency : ICurrency
    {
        private readonly List<string> _validCurrencies;

        public Currency()
        {
            _validCurrencies = new List<string> { "USD", "GBP" }; // Should be populated from a service to allow extra currency types to be checked in the future
        }        
                
        public bool IsValid(string currency)
        {
            var isValid = _validCurrencies.Any(x => x.Contains(currency));
            return isValid;
        }

    }

    public interface ICurrency
    {
        bool IsValid(string currency);
    }
}