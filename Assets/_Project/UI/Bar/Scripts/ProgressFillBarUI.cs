using UnityEngine;
using TMPro;
using Core.Bars;
using UnityEngine.UI;

namespace UI.Bars
{
    public class ProgressFillBarUI : MonoBehaviour
    {
        [field: SerializeField] private BarContainer _barContainer;
        [field: SerializeField] private TMP_Text _progressText;
        [field: SerializeField] private Image _backgroundFill;
        private BarValues _barValues => _barContainer.Bar.BarValues;

        private void OnEnable()
        {
            _barContainer.BarCreated += ChangeProgressText;
        }

        private void Start()
        {
            _barValues.CurrentValueChanhed += ChangeProgressText;
            _barValues.MaxValueChanhed += ChangeProgressText;
        }

        private void OnDisable()
        {
            _barContainer.BarCreated -= ChangeProgressText;
            _barValues.CurrentValueChanhed -= ChangeProgressText;
            _barValues.MaxValueChanhed -= ChangeProgressText;
        }

        private void ChangeProgressText()
        {
            _progressText.text = $"{_barValues.CurrentValue} / {_barValues.MaxValue}";
            _backgroundFill.fillAmount = (float)_barValues.CurrentValue / _barValues.MaxValue;
        }
    }
}
