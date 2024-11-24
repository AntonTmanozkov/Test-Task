using UnityEngine;
using Core.Bars;
using UnityEngine.UI;

namespace UI.Bars
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private BarCheckerBuy _barCheckerBuy;
        [SerializeField] private Button _button;

        private void OnEnable()
        {
            _button.onClick.AddListener(BuyBar);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(BuyBar);
        }
        
        private void BuyBar()
        {   
            _barCheckerBuy.Check();
        }
    }
}
