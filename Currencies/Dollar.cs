using CurrencyConverter.Interfaces;

namespace CurrencyConverter.Currencies
{
    public class Dollar : ICurrency
    {
        private string _sing = "$";

        public string getSign()
        {
            return _sing;
        }
    }
}