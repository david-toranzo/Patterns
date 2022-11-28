using Observers.Core;
using UnityEngine;
using Patterns.ServiceLocator;
using Toranzo.Installer;
using Toranzo.SceneSystem;

public class LoginSuccessReceiverSceneLoaderInstaller : MonoInstaller<LoginSuccessReceiverSceneLoader>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _receiverSubscriberInstaller;

    [Header("Data")]
    [SerializeField] private SceneDataSO _sceneDataToLoad;

    protected override LoginSuccessReceiverSceneLoader GetDataType()
    {
        ISceneSystemLoader sceneLoader = ServiceLocator.Instance.GetService<ISceneSystemLoader>();

        return new LoginSuccessReceiverSceneLoader(_receiverSubscriberInstaller.Data, sceneLoader, _sceneDataToLoad.SceneData);
    }
}
