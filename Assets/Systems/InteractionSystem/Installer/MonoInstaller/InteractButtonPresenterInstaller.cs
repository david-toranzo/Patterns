using Toranzo.Installer;
using UnityEngine;

namespace Interaction
{
    public class InteractButtonPresenterInstaller : MonoInstaller<IInteractPresenter>
    {
        [SerializeField] private ButtonClicker _clickButton;

        protected override IInteractPresenter GetDataType()
        {
            return new InteractPresenter(_clickButton);
        }
    }
}