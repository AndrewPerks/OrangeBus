using System;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter : Currency
	{
		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
		    try
		    {
		        var isInputValid = IsValid(inputCurrency);
                var isOutputValid = IsValid(outputCurrency);

		        if (!isInputValid || !isOutputValid)
		        {
		            throw new InvalidCurrencyException("The currency is an invalid format");
		        }

                // Conversion
		        var rate = GetRate(inputCurrency);
		        amount = amount * rate;
		        return amount;
		    }
		    catch (InvalidCurrencyException ex)
		    {
                Console.WriteLine(ex.Message, ex);
		        throw;
		    }		
		}
	}
}
