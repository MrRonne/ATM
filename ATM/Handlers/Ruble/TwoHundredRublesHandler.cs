namespace ATM.Handlers.Ruble
{
    public class TwoHundredRublesHandler : RublesHandlerBase
    {
        protected override int Value => 200;

        protected TwoHundredRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}