using System.Collections.Generic;
using ATM.Handlers;
using ATM.Handlers.Dollar;
using ATM.Handlers.Euro;
using ATM.Handlers.Ruble;

namespace ATM
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat(BanknoteHandler handler)
        {
            _handler = handler;
        }

        public bool Validate(Banknote banknote) => _handler.Validate(banknote);

        public virtual IEnumerable<Banknote> CashOut(CurrencyType currency, int amount) =>
            _handler.CashOut(currency, amount);
    }
}