using System.Collections.Generic;
using System.Linq;

namespace ATM.Handlers
{
    public abstract class CurrencyHandlerBase : BanknoteHandler
    {
        protected virtual int Value { get; }
        protected virtual CurrencyType Currency { get; }

        protected CurrencyHandlerBase(BanknoteHandler nextHandler) : base(nextHandler)
        { }

        public override bool Validate(Banknote banknote)
        {
            if (banknote.Currency == Currency && banknote.Value == Value)
                return true;
            return base.Validate(banknote);
        }

        public override IEnumerable<Banknote> CashOut(CurrencyType currency, int amount)
        {
            var cash = new List<Banknote>();
            while (amount >= Value)
            {
                cash.Add(new Banknote(Currency, Value));
                amount -= Value;
            }
            return cash.Concat(base.CashOut(currency, amount));
        }
    }
}