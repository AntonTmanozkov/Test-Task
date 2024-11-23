using UnityEngine;
using Zenject;

namespace Core.Bars
{
    public class BarBoxMonoinstallet : MonoInstaller
    {
        private BarBox _barBox;
        public override void InstallBindings()
        {
            _barBox = new();
            Container.Bind<BarBox>().FromInstance(_barBox).AsSingle();
        }
    }
}
