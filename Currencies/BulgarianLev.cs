using CurrencyConverter.Interfaces;

namespace CurrencyConverter.Currencies
{
    public class BulgarianLev : ICurrency
    {
        private string _sing = "лв";

        public string getSign()
        {
            return _sing;
        }
    }
}