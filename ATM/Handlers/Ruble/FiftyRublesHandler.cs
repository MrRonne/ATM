namespace ATM.Handlers.Ruble
{
    public class FiftyRublesHandler : RublesHandlerBase
    {
        protected override int Value => 50;

        protected FiftyRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}