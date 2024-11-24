using UnityEngine;
using Core.Bars;
using UnityEngine.UI;
using TMPro;

namespace UI.Bars
{
    public class UpgraderButton : MonoBehaviour
    {
        [field: SerializeField] private BarContainer _barContainer;
        [field: SerializeField] private Button _button;
        [field: SerializeField] private TMP_Text _priceUpgradeText;
        private BarCheckerUpgrade _barCheckerUpgrade => _barContainer.Bar.BarCheckerUpgrade; 
        private BarUpgrader _barUpgrader => _barContainer.Bar.BarUpgrader; 

        private void OnEnable()
        {
            _button.onClick.AddListener(CollectCurrency);
        }

        private void Start()
        {
            _barUpgrader.UpgradedBar += UpdateText;
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(CollectCurrency);
            _barUpgrader.UpgradedBar -= UpdateText;
        }

        private void CollectCurrency()
        {
            _barCheckerUpgrade.Check();
        }

        private void UpdateText()
        {
            _priceUpgradeText.text = _barUpgrader.CostImprovement.ToString();
        }
    }
}
