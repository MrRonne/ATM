namespace ATM.Handlers.Dollar
{
    public class TwentyDollarsHandler : DollarsHandlerBase
    {
        protected override int Value => 20;

        public TwentyDollarsHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}