namespace ATM.Handlers.Ruble
{
    public class TwoThousandRublesHandler : RublesHandlerBase
    {
        protected override int Value => 2000;

        protected TwoThousandRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}