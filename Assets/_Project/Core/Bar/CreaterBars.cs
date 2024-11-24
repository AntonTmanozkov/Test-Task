using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Core.Bars
{
    public class CreaterBars : MonoBehaviour
    {
        [field: SerializeField] private int _startCountBar;
        [Inject] private BarBox _barBox;
        [Inject] private Wallet _wallet;

        public delegate void BarsAddedDelegate(Bar bar);
        public event BarsAddedDelegate BarsAdded;

        private void Awake() // По факту это должно быть в загрузке баров. Короче, класс должен быть связан с сохранениями баров.
        {
            for (var i = 0; i < _startCountBar; i++)
            {
                CreateBar();
            }
        }

        public void CreateBar()
        {
            Bar bar = new(_wallet);
            _barBox.AddBar(bar); // BarBox в итоге мне так и не пригодился, начал делать под ту систему, что у нас уже.

            BarsAdded?.Invoke(bar);
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
