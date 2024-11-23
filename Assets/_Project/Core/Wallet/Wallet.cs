using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Wallet : MonoBehaviour
{
    private List<Currency> _currencies = new();

    public Wallet()
    {
        foreach (CurrencyType currencyType in Enum.GetValues(typeof(CurrencyType)))
        {
            Currency currency = new(currencyType);
            _currencies.Add(currency);
        }
    }

    public Currency GetCurrency(CurrencyType currencyType)
    {
        try
        {
            return _currencies.FirstOrDefault(x => x.CurrencyType == currencyType);
        }
        catch 
        {
            throw new KeyNotFoundException($"Currency {currencyType} not found.");
        }
    }
}
