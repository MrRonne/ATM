using ATM.Handlers;
using ATM.Handlers.Dollar;
using ATM.Handlers.Euro;
using ATM.Handlers.Ruble;

namespace ATM
{
    public class Bancomat
    {
        private readonly BanknoteHandler _handler;

        public Bancomat()
        {
            _handler = new TenRublesHandler(null);;
            _handler = new TenDollarsHandler(_handler);
            _handler = new FiftyDollarsHandler(_handler);
            _handler = new HundredDollarsHandler(_handler);
        }

        public bool Validate(IBanknote banknote)
        {
            return _handler.Validate(banknote);
        }
    }
}