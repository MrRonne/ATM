namespace ATM
{
    public interface IBanknote
    {
        CurrencyType Currency { get; }
        string Value { get; }
    }
}