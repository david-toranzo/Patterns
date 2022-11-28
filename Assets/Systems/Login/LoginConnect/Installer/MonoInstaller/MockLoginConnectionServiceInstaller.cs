using Observers.Core;
using Services.Core;
using Toranzo.Installer;
using UnityEngine;

public class MockLoginConnectionServiceInstaller : MonoInstaller<IService<string>>
{
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _loginSucessEvent;
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _loginFailedEvent;

    protected override IService<string> GetDataType()
    {
        return new MockLoginConnectionService(_loginSucessEvent.Data, _loginFailedEvent.Data);
    }
}
