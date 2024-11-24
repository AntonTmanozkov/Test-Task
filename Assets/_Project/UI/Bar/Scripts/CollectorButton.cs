using UnityEngine;
using Core.Bars;
using UnityEngine.UI;

namespace UI.Bars
{
    public class CollectorButton : MonoBehaviour
    {
        [field: SerializeField] private BarContainer _barContainer;
        [field: SerializeField] private Button _button;
        private CollectorCurrencyBar _collectorCurrencyBar => _barContainer.Bar.CollectorCurrencyBar; 

        private void OnEnable()
        {
            _button.onClick.AddListener(CollectCurrency);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(CollectCurrency);
        }

        private void CollectCurrency()
        {
            _collectorCurrencyBar.CollectCurrency();
        }
    }
}
