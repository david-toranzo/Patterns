using Toranzo.Installer;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Command.Examples
{
    public class CommandLoadUIControllerInstaller : MonoInstaller<CommandLoadUIController>
    {
        [Header("UI")]
        [SerializeField] private GameObject _backGround;
        [SerializeField] private Slider _sliderCountProgress;

        [Header("References")]
        [SerializeField] private MonoInstaller<ICommandManager> _commandManager;

        protected override CommandLoadUIController GetDataType()
        {
            return new CommandLoadUIController(_commandManager.Data, _backGround, _sliderCountProgress);
        }
    }
}
