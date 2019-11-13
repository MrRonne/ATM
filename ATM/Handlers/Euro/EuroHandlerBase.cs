namespace ATM.Handlers.Euro
{
    public abstract class EuroHandlerBase : CurrencyHandlerBase
    {
        protected override CurrencyType Currency => CurrencyType.Euro;

        protected EuroHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}