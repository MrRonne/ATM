﻿namespace ATM
{
    public interface IBanknote
    {
        CurrencyType Currency { get; }
        int Value { get; }
    }
}