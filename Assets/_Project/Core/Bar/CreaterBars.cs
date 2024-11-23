using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Core.Bars
{
    public class CreaterBars : MonoBehaviour
    {
        [field: SerializeField] private Bar _prototypeBar;
        [Inject] private BarBox _barBox;

        public delegate void BarsAddedDelegate();
        public event BarsAddedDelegate BarsAdded;

        private void Awake() // По факту это должно быть в загрузке баров. Короче, класс должен быть связан с сохранениями баров.
        {
            _barBox.AddBar(_prototypeBar);

            BarsAdded?.Invoke();
        }

        private void OnDisable()
        {
            foreach(Bar bar in _barBox.BarList)
            {
                bar.ControlMoneyBar.DetachHandler();
            }
        }
    }
}
