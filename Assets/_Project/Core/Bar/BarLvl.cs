using UnityEngine;

namespace Core.Bars
{
    public class BarLvl : MonoBehaviour
    {
        private int _lvl = 1;
        public int Lvl { get =>  _lvl; set { if (value < 1) value = 1; _lvl = value; } }
    }
}
