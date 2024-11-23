using System;
using UnityEngine;

namespace Core.Bars
{
    [Serializable]
    public class BarValues
    {
        [SerializeField] private int _currentValue;
        [SerializeField] private int _maxValue;
        public int MaxValue { get => _maxValue; set { if (value < 0) value = 0; _maxValue = value; }}
        public int CurrentValue { get => _currentValue; set { _currentValue = Math.Clamp(value, 0, MaxValue); CurrentValueChanhed?.Invoke(_currentValue); } }
        public delegate void CurrentValueChanhedDelegate(int CurrentValue);
        public event CurrentValueChanhedDelegate CurrentValueChanhed;

        public void Increase(int amount)
        {
            CurrentValue += amount;
        }

        public void Decrease(int amount)
        {
            CurrentValue -= amount;
        }
    }
}
