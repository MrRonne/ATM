namespace ATM.Handlers.Ruble
{
    public abstract class RublesHandlerBase : CurrencyHandlerBase
    {
        protected override CurrencyType Currency => CurrencyType.Ruble;

        protected RublesHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}