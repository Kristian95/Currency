using System;
using CurrencyConverter.Currencies;
using CurrencyConverter.Interfaces;

namespace CurrencyConverter.Factories
{
    public class CurrencyFactory
    {
        private string _currency;

        public CurrencyFactory(string currency)
        {
            _currency = currency;
        }

        public ICurrency create()
        {
            ICurrency currencyClass = new Dollar();

            switch (_currency)
            {
                case "Euro":
                    currencyClass = new Euro();
                    break;
                case "Lev":
                    currencyClass = new BulgarianLev();
                    break;
                default:
                    currencyClass = new Dollar();
                    break;
            }

            return currencyClass;
        }
    }
}
