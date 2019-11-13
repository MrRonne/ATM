namespace ATM.Handlers.Ruble
{
    public class FiveHundredRublesHandler : RublesHandlerBase
    {
        protected override int Value => 500;

        protected FiveHundredRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}