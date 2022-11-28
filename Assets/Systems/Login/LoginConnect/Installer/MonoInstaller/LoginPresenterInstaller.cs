using Toranzo.Installer;
using UnityEngine;

namespace Interaction
{
    public class LoginPresenterInstaller : MonoInstaller<LoginPresenter>
    {
        [Header("Presenters")]
        [SerializeField] private MonoInstaller<IInteract> _buttonPresenter;

        [Header("References")]
        [SerializeField] private MonoInstaller<ILogin> _loginUseCase;
        [SerializeField] private MonoInstaller<ILoginView> _viewLogin;

        protected override LoginPresenter GetDataType()
        {
            return new LoginPresenter(_loginUseCase.Data, _viewLogin.Data, _buttonPresenter.Data);
        }
    }
}