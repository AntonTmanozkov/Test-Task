using UnityEngine;

public class Currency
{
    private int _value;
    public int Value { get => _value; set { if (value < 0) value = 0; _value = value; } }
    public CurrencyType CurrencyType { get; private set; }

    public Currency(CurrencyType currencyType, int initValue = 0)
    {
        CurrencyType = currencyType;
        Value = initValue;
    }
}
