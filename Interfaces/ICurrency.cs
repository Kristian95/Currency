namespace CurrencyConverter.Interfaces
{
    public interface ICurrency
    {
        string getSign();
        void setAmount(decimal amount);
        void getInfoAmount();
    }
}