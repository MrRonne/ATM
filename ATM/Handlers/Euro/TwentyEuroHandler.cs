namespace ATM.Handlers.Euro
{
    public class TwentyEuroHandler : EuroHandlerBase
    {
        protected override int Value => 20;

        public TwentyEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}