namespace ATM.Handlers
{
    public abstract class CurrencyHandlerBase : BanknoteHandler
    {
        protected virtual int Value { get; }
        protected virtual CurrencyType Currency { get; }

        protected CurrencyHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        { }

        public override bool Validate(IBanknote banknote)
        {
            if (banknote.Currency == Currency && banknote.Value == Value)
                return true;
            return base.Validate(banknote);
        }
    }
}