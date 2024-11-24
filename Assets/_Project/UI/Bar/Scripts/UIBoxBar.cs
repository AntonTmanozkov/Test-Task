using UnityEngine;
using Core.Bars;
using System.Collections.Generic;
using Zenject;

namespace UI.Bars
{
    public class UIBoxBar : MonoBehaviour
    {
        [field: SerializeField] private CreaterBars _createrBars;
        [field: SerializeField] private BarContainer _barContainer_PREFAB;
        [field: SerializeField] private Transform _barsParent;
        private List<BarContainer> _barContainers = new();

        private void OnEnable()
        {
            _createrBars.BarsAdded += CreatePrefabsBar;
        }
        
        private void OnDisable()
        {
            _createrBars.BarsAdded -= CreatePrefabsBar;
        }

        private void CreatePrefabsBar(Bar bar)
        {
            BarContainer barContainer = Instantiate(_barContainer_PREFAB, _barsParent).Init(bar);
            barContainer.gameObject.transform.SetSiblingIndex(0);
            _barContainers.Add(barContainer);
        }
    }
}
