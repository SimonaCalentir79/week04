using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Rate
    {
        private List<Rate> lstPrices = new List<Rate>();

        public Rate(decimal amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public void DeleteValueOfRate(decimal valueToDelete)
        {
            foreach (var rateFromRates in lstPrices)
            {
                if (rateFromRates.Amount == valueToDelete)
                {
                    lstPrices.Remove(rateFromRates);
                }
            }
        }

        public void DeleteCurrencyFromRates(string currencyToDelete)
        {
            foreach (var currencyFromRates in lstPrices)
            {
                if (currencyFromRates.Currency == currencyToDelete)
                {
                    lstPrices.Remove(currencyFromRates);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"\t\t Price is {Amount} {Currency}");
        }
    }
}
