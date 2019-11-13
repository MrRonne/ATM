namespace ATM.Handlers.Dollar
{
    public class TenDollarsHandler : DollarsHandlerBase
    {
        protected override int Value => 10;

        public TenDollarsHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}