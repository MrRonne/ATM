namespace ATM.Handlers.Dollar
{
    public abstract class DollarsHandlerBase : BanknoteHandler
    {
        public override bool Validate(string banknote)
        {
            if (banknote.Equals($"{Value}$"))
            {
                return true;
            }
            return base.Validate(banknote);
        }

        protected abstract int Value { get; }

        protected DollarsHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        {
        }
    }
}