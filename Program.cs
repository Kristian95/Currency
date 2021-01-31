using System;
using System.Linq;
using CurrencyConverter.Factories;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = {"Lev", "Dollar", "Euro"};
            Console.WriteLine("Supported currencies: Lev, Dollar, Euro");
            Console.WriteLine("Enter currency: ");
            string currency = Console.ReadLine();

            if (! currencies.Contains(currency)) {
                Console.WriteLine("Sorry! Currency {0} is not suported", currency);

                return;
            }

            var currencyFactory = new CurrencyFactory(currency).create();
            Console.WriteLine("Enter amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            currencyFactory.setAmount(amount);
            currencyFactory.getInfoAmount();
        }
    }
}
