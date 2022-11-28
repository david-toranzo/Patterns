using Toranzo.Installer;
using UnityEngine;
using UnityEngine.UI;

public class LoginViewInstaller : MonoInstaller<ILoginView>
{
    [Header("UI")]
    [SerializeField] private InputField _nameInput;

    protected override ILoginView GetDataType()
    {
        return new LoginView(_nameInput);
    }
}
