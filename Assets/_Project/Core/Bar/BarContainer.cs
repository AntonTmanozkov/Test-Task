using UnityEngine;

namespace Core.Bars
{
    public class BarContainer : MonoBehaviour
    {
        [field: SerializeField] public Bar Bar { get; private set; }
        public delegate void BarCreatedDelegate();
        public event BarCreatedDelegate BarCreated;
        public BarContainer Init(Bar bar)
        {
            Bar = bar;
            BarCreated?.Invoke();
            return this;
        }
    }
}
