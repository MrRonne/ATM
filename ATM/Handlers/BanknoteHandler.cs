using System;
using System.Collections.Generic;

namespace ATM.Handlers
{
    public abstract class BanknoteHandler
    {
        private readonly BanknoteHandler _nextHandler;

        protected BanknoteHandler(BanknoteHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual bool Validate(Banknote banknote)
        {
            return _nextHandler != null && _nextHandler.Validate(banknote);
        }

        public virtual IEnumerable<Banknote> CashOut(CurrencyType currency, int amount)
        {
            if (amount == 0)
                return new List<Banknote>();
            if (_nextHandler == null)
                throw new Exception($"Unable to cash out. The rest is {amount}.");

            return _nextHandler.CashOut(currency, amount);
        }
    }
}