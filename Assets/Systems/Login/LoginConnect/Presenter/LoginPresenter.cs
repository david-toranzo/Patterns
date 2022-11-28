namespace Interaction
{
    public class LoginPresenter
    {
        private ILoginView _loginView;
        private ILogin _loginUseCase;

        public LoginPresenter(ILogin loginPresenter, ILoginView loginView, IInteract buttonPresenter)
        {
            _loginUseCase = loginPresenter;
            _loginView = loginView;

            buttonPresenter.OnInteract += StartWithNewLogin;
        }

        private void StartWithNewLogin()
        {
            _loginUseCase.Login(_loginView.GetNameUser());
        }
    }
}