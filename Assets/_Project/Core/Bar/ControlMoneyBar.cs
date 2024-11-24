using UnityEngine;
using Timer;
using System;

namespace Core.Bars
{
    [Serializable]
    public class ControlMoneyBar
    {
        [SerializeField] private int _moneyPerTick = 1;

        private GlobalTimer _timerBar;
        private BarValues _barValues;

        public ControlMoneyBar(Bar bar)
        {
            _timerBar = bar.GlobalTimer;
            _ = _timerBar.TimerEnd();
            _barValues = bar.BarValues;

            RegisterHandler();
        }

        private void RegisterHandler()
        {
            _timerBar.TimerEnded += AddingMoney;
        } 

        public void DetachHandler()
        {
            _timerBar.TimerEnded -= AddingMoney;
        }

        private void AddingMoney()
        {
            _barValues.CurrentValue += _moneyPerTick;
        }
    }
}
