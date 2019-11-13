namespace ATM.Handlers.Ruble
{
    public class ThousandRublesHandler : RublesHandlerBase
    {
        protected override int Value => 1000;

        protected ThousandRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}