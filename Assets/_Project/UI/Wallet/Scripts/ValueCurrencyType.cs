using UnityEngine;
using Zenject;
using TMPro;

namespace UI.Wallets
{
    public class ValueCurrencyType : MonoBehaviour
    {
        [SerializeField] private CurrencyType _currencyType;
        [SerializeField] private TMP_Text _currencyText;
        [Inject] private Wallet _wallet;

        private void OnEnable()
        {
            _wallet.GetCurrency(_currencyType).ChangedValue += ChangeCurrencyText;
            ChangeCurrencyText(_wallet.GetCurrency(_currencyType).Value);
        }

        private void OnDisable()
        {
            _wallet.GetCurrency(_currencyType).ChangedValue -= ChangeCurrencyText;
        }

        private void ChangeCurrencyText(int newValue)
        {
            _currencyText.text = newValue.ToString();
        }
    }
}
