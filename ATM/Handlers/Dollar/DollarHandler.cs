namespace ATM.Handlers.Dollar
{
    public class DollarHandler : DollarsHandlerBase
    {
        protected override int Value => 1;

        public DollarHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}