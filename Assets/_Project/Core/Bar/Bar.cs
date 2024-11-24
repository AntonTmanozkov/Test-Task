using System;
using Timer;
using UnityEngine;

namespace Core.Bars
{
    public class Bar
    {
        [field: SerializeField] public CurrencyType CurrencyType { get; private set; } = CurrencyType.MainSoftCurrency;
        public GlobalTimer GlobalTimer { get; private set; } = new();
        public BarValues BarValues { get; private set; } = new();
        public ControlMoneyBar ControlMoneyBar { get; private set; }
        public BarUpgrader BarUpgrader { get; private set; }
        public CollectorCurrencyBar CollectorCurrencyBar { get; private set; }
        public BarCheckerUpgrade BarCheckerUpgrade { get; private set; }
        public BarLvl BarLvl { get; private set; } = new();
        public Wallet _wallet { get; private set; }

        public Bar(Wallet wallet)
        {
            _wallet = wallet;

            ControlMoneyBar = new(this); // Может лучше передавать конкретные классы?
            BarUpgrader = new(this); // Может лучше передавать конкретные классы?
            CollectorCurrencyBar = new(BarValues, CurrencyType, _wallet);
            BarCheckerUpgrade = new(BarUpgrader, CurrencyType, _wallet);
        }
    }
}
