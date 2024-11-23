using UnityEngine;
using Zenject;

public class WalletInstaller : MonoInstaller
{
    private Wallet _wallet;
    public override void InstallBindings()
    {
        _wallet = new();
        Container.Bind<Wallet>().FromInstance(_wallet).AsSingle();
    }
}
