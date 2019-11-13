namespace ATM.Handlers.Euro
{
    public class FiftyEuroHandler : EuroHandlerBase
    {
        protected override int Value => 50;

        public FiftyEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}