using Observers.Core;
using Toranzo.SceneSystem;

public class LoginSuccessReceiverSceneLoader
{
    private ISceneLoader _sceneLoader;
    private SceneData _sceneDataToLoad;

    public LoginSuccessReceiverSceneLoader(ISubscriberWithData<string> receiverWithData,
                                              ISceneLoader sceneLoader,
                                              SceneData sceneDataToLoad)
    {
        _sceneLoader = sceneLoader;
        _sceneDataToLoad = sceneDataToLoad;

        receiverWithData.OnReceiveData += RequestSucessLoadScene;
    }

    private void RequestSucessLoadScene(string isConnectionSuccess)
    {
       _sceneLoader.LoadScene(_sceneDataToLoad);
    }
}
