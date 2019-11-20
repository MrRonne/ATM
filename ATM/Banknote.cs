namespace ATM
{
    public struct Banknote
    {
        public readonly CurrencyType Currency;
        public readonly int Value;

        public Banknote(CurrencyType currency, int value)
        {
            Currency = currency;
            Value = value;
        }

        public override string ToString() => $"{Value} {Currency}{(Value > 1 ? "s" : "")}";
    }
}