using System;
using UnityEngine;

namespace Core.Bars
{
    [Serializable]
    public class BarUpgrader
    {
        private Bar _bar;
        [SerializeField] private int _costImprovement;
        [SerializeField] private float _percentageCostImprovement;
        [SerializeField] private float _percentageCapacityImprovement;
        [SerializeField] private float _percentageSpeedImprovement;
        public int CostImprovement { get => _costImprovement; set { _costImprovement = value; } }

        public delegate void UpgradedBarDelegate();
        public event UpgradedBarDelegate UpgradedBar;

        public BarUpgrader(Bar bar)
        {
            _bar = bar;
        }

        public void UpgradeBar()
        {
            UpgradeLvl();
            UpgradeSpeedTimer();
            UpgradeCostImprovement();
            UpgradeMaxValueBar();

            UpgradedBar?.Invoke();
        }
        
        private void UpgradeLvl()
        {
            _bar.BarLvl.Lvl++;
        }

        private void UpgradeSpeedTimer()
        {
            _bar.GlobalTimer.WaitingTime *= _percentageSpeedImprovement;
        }

        private void UpgradeCostImprovement()
        {
            _costImprovement *= (int)Math.Round(_percentageCostImprovement);
        }

        private void UpgradeMaxValueBar()
        {
            _bar.BarValues.MaxValue *= (int)Math.Round(_percentageCapacityImprovement);
        }
    }
}
