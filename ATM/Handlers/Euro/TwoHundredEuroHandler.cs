namespace ATM.Handlers.Euro
{
    public class TwoHundredEuroHandler : EuroHandlerBase
    {
        protected override int Value => 200;

        public TwoHundredEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}