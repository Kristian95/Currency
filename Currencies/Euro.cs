using CurrencyConverter.Interfaces;
using System;

namespace CurrencyConverter.Currencies
{
    public class Euro : ICurrency
    {
        private string _sing = "€";
        private decimal _amount;

        public void setAmount(decimal amount)
        {
            _amount = amount;
        }

        public string getSign()
        {
            return _sing;
        }

        public void getInfoAmount()
        {
            Console.WriteLine("{0} {1}", _amount, _sing);
        }
    }
}
