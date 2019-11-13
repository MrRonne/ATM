namespace ATM.Handlers.Dollar
{
    public class TwoDollarsHandler : DollarsHandlerBase
    {
        protected override int Value => 2;

        public TwoDollarsHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}