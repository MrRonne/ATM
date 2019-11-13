namespace ATM.Handlers.Dollar
{
    public class HundredDollarsHandler : DollarsHandlerBase
    {
        protected override int Value => 100;

        public HundredDollarsHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}