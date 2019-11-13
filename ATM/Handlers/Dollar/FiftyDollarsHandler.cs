namespace ATM.Handlers.Dollar
{
    public class FiftyDollarsHandler : DollarsHandlerBase
    {
        protected override int Value => 50;

        public FiftyDollarsHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}