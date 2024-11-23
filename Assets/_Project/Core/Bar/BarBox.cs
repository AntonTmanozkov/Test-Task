using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Core.Bars
{
    public class BarBox
    {
        private List<Bar> _barList = new();
        public List<Bar> BarList => _barList.ToList();

        public void AddBar(Bar bar)
        {
            BarList.Add(bar);
        }
    }
}
