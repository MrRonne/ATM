namespace ATM.Handlers.Ruble
{
    public class TenRublesHandler : RublesHandlerBase
    {
        protected override int Value => 10;

        public TenRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}