using Services.Core;

public class LoginUseCase : ILogin
{
    private IService<string> _serviceLogin;

    public LoginUseCase(IService<string> serviceLogin)
    {
        _serviceLogin = serviceLogin;
    }

    public void Login(string name)
    {
        _serviceLogin.Send(name);
    }
}
