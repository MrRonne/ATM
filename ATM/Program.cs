using System;
using ATM.Handlers;
using ATM.Handlers.Dollar;
using ATM.Handlers.Euro;
using ATM.Handlers.Ruble;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            BanknoteHandler handler = new TwoDollarsHandler(null);
            handler = new TenDollarsHandler(handler);
            handler = new FiftyDollarsHandler(handler);
            handler = new HundredDollarsHandler(handler);
            var bancomat = new Bancomat(handler);

            Console.WriteLine("Validating banknotes...\n");
            var fiftyDollars = new Banknote(CurrencyType.Dollar, 50);
            Console.WriteLine(fiftyDollars + ": " + bancomat.Validate(fiftyDollars));
            var thirteenDollars = new Banknote(CurrencyType.Dollar, 13);
            Console.WriteLine(thirteenDollars + ": " + bancomat.Validate(thirteenDollars));

            Console.WriteLine("\n\nCashing out...");
            var currency = CurrencyType.Dollar;
            var amount = 270;
            Console.WriteLine($"\n{amount} {currency} cash:");
            var cash = bancomat.CashOut(currency, amount);
            foreach (var banknote in cash)
                Console.WriteLine(banknote);

            amount = 273;
            Console.WriteLine($"\n{amount} {currency} cash:");
            try
            {
                cash = bancomat.CashOut(currency, amount);
                foreach (var banknote in cash)
                    Console.WriteLine(banknote);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}