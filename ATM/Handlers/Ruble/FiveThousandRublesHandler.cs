namespace ATM.Handlers.Ruble
{
    public class FiveThousandRublesHandler : RublesHandlerBase
    {
        protected override int Value => 5000;

        protected FiveThousandRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}