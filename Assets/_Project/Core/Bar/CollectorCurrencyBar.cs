using UnityEngine;

namespace Core.Bars
{
    public class CollectorCurrencyBar
    {
        private BarValues _barValues;
        private CurrencyType _currencyType;
        private Wallet _wallet;

        public CollectorCurrencyBar(BarValues barValues, CurrencyType currencyType, Wallet wallet)
        {
            _barValues = barValues;
            _currencyType = currencyType;
            _wallet = wallet;
        }

        public void CollectCurrency()
        {
            _wallet.GetCurrency(_currencyType).Value += _barValues.CurrentValue;
            _barValues.CurrentValue = 0;
        }
    }
}
