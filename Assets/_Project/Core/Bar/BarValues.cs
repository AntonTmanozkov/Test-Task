using System;
using UnityEngine;

namespace Core.Bars
{
    public class BarValues
    {
        private int _currentValue;
        private int _maxValue = 1000;
        public int MaxValue { get => _maxValue; set { if (value < 0) value = 0; _maxValue = value; MaxValueChanhed?.Invoke(); }}
        public int CurrentValue { get => _currentValue; set { _currentValue = Math.Clamp(value, 0, MaxValue); CurrentValueChanhed?.Invoke(); } }
        public delegate void CurrentValueChanhedDelegate();
        public event CurrentValueChanhedDelegate CurrentValueChanhed;
        public delegate void MaxValueChanhedDelegate();
        public event MaxValueChanhedDelegate MaxValueChanhed;
    }
}
