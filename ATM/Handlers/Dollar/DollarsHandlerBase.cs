namespace ATM.Handlers.Dollar
{
    public abstract class DollarsHandlerBase : CurrencyHandlerBase
    {
        protected override CurrencyType Currency => CurrencyType.Dollar;

        protected DollarsHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}