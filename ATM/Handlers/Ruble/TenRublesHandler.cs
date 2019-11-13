namespace ATM.Handlers.Ruble
{
    public class TenRublesHandler : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            if (banknote.Equals("10 Рублей"))
            {
                return true;
            }
            return base.Validate(banknote);
        }

        public TenRublesHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}