using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CurrencyConverter
{
    
    public class Currency : ICurrency
    {
        private readonly List<KeyValuePair<string, decimal>> _validCurrencies;

        public Currency()
        {
            _validCurrencies = new List<KeyValuePair<string, decimal>> {new KeyValuePair<string, decimal>("USD", 0.8m), new KeyValuePair<string, decimal>( "GBP", 1.25m )}; // Should be populated from a service to allow extra currency types to be checked in the future
        }
        
        public decimal GetRate(string currency)
        {
            var currencyKeyPair = _validCurrencies.FirstOrDefault(x => x.Key.Contains(currency));
            var rate = currencyKeyPair.Value;
            return rate;
        }
                
        public bool IsValid(string currency)
        {
            var isValid = _validCurrencies.Any(x => x.Key.Contains(currency));
            return isValid;
        }

    }

    public interface ICurrency
    {
        bool IsValid(string currency);
    }
}