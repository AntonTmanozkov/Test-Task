using UnityEngine;
using Zenject;

namespace Core.Bars
{
    public class BarCheckerUpgrade 
    {
        private BarUpgrader _barUpgrader;
        private CurrencyType _currencyType;
        private Currency _currency => _wallet.GetCurrency(_currencyType);
        private Wallet _wallet;

        public BarCheckerUpgrade(BarUpgrader barUpgrader, CurrencyType currencyType, Wallet wallet)
        {
            _barUpgrader = barUpgrader;
            _currencyType = currencyType;
            _wallet = wallet;
        }   

        public void Check()
        {
            if (_currency.Value >= _barUpgrader.CostImprovement)
            {
                _barUpgrader.UpgradeBar();
                _currency.Value -= _barUpgrader.CostImprovement;
            }
        }
    }
}
