using UnityEngine;
using Zenject;

namespace Core.Bars
{
    public class BarCheckerBuy : MonoBehaviour // Можно было бы передать через zenject, но зачем париться? Игра всё равно не расчитана на закрытие главного окна.
    {
        private const int _costBuyBar = 500;
        [SerializeField] private CreaterBars _createrBars;
        [Inject] private Wallet _wallet;
        private Currency _currency => _wallet.GetCurrency(CurrencyType.MainSoftCurrency);

        public void Check()
        {
            if (_currency.Value >= _costBuyBar)
            {
                _createrBars.CreateBar();
                _currency.Value -= _costBuyBar;
            }
        }
    }
}
