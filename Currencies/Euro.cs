using CurrencyConverter.Interfaces;

namespace CurrencyConverter.Currencies
{
    public class Euro : ICurrency
    {
        private string _sing = "€";

        public string getSign()
        {
            return _sing;
        }
    }
}
