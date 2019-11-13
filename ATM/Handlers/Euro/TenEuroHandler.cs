﻿namespace ATM.Handlers.Euro
{
    public class TenEuroHandler : EuroHandlerBase
    {
        protected override int Value => 10;

        public TenEuroHandler(BanknoteHandler nextHandler) : base(nextHandler)
        { }
    }
}