using Services.Core;
using Toranzo.Installer;
using UnityEngine;

public class LoginUseCaseInstaller : MonoInstaller<ILogin>
{
    [Header("References")]
    [SerializeField]
    private MonoInstaller<IService<string>> _loginServerData;

    protected override ILogin GetDataType()
    {
        return new LoginUseCase(_loginServerData.Data);
    }
}
