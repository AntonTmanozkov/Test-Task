using UnityEngine;
using TMPro;
using Core.Bars;

namespace UI.Bars
{
    public class LvlBarUI : MonoBehaviour
    {
        [field: SerializeField] private BarContainer _barContainer;
        [field: SerializeField] private TMP_Text _lvlText;
        private BarLvl _barLvl => _barContainer.Bar.BarLvl;

        private void OnEnable()
        {
            _barContainer.BarCreated += ChangeLvlText;
        }

        private void Start()
        {
            _barLvl.ChangedValueLvl += ChangeLvlText;
        }

        private void OnDisable()
        {
            _barContainer.BarCreated -= ChangeLvlText;
            _barLvl.ChangedValueLvl -= ChangeLvlText;
        }

        private void ChangeLvlText()
        {
            _lvlText.text = $"Lvl {_barLvl.Lvl}" ;
        }
    }
}
