using Observers.Core;
using Services.Core;

public class MockLoginConnectionService : IService<string>
{
    private string _correctUser = "esta";

    private ISubscriberWithData<string> _sucessSubscribe;
    private ISubscriberWithData<string> _failedSubscribe;

    public MockLoginConnectionService(ISubscriberWithData<string> sucessSubscribe, ISubscriberWithData<string> failedSubscribe)
    {
        _sucessSubscribe = sucessSubscribe;
        _failedSubscribe = failedSubscribe;
    }

    public void Send(string data)
    {
        bool areCredentialsEquals = AreCreditialsEquals(data);

        if (areCredentialsEquals)
        {
            _sucessSubscribe?.OnReceiveData.Invoke("The connection login was right");
            return;
        }

        _failedSubscribe?.OnReceiveData.Invoke("The username is wrong");
    }

    private bool AreCreditialsEquals(string username)
    {
        bool isCorrectUser = string.Equals(username, _correctUser);

        return isCorrectUser;
    }
}
