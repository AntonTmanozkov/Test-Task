using System;
using Timer;
using UnityEngine;

namespace Core.Bars
{
    [Serializable]
    public class Bar
    {
        [field: SerializeField] public GlobalTimer GlobalTimer { get; private set; } = new();
        [field: SerializeField] public BarValues BarValues { get; private set; } = new();
        [field: SerializeField] public ControlMoneyBar ControlMoneyBar { get; private set; }
        [field: SerializeField] public BarUpgrader BarUpgrader { get; private set; }
        public BarLvl BarLvl { get; private set; } = new();

        public Bar()
        {
            ControlMoneyBar = new(this);
            BarUpgrader = new(this);
        }
    }
}
