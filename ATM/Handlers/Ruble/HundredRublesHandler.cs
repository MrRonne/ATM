namespace ATM.Handlers.Ruble
{
    public class HundredRublesHandler : RublesHandlerBase
    {
        protected override int Value => 100;

        protected HundredRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}