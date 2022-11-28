using UnityEngine.UI;

public class LoginView : ILoginView
{
    private InputField _nameInput;

    public LoginView(InputField nameInput)
    {
        _nameInput = nameInput;
    }

    public string GetNameUser() => _nameInput.text;
}
