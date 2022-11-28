using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Command.Examples
{
    public class CommandLoadUIController 
    {
        private readonly GameObject _backGround;
        private readonly Slider _sliderCountProgress;

        private readonly ICommandManager _commandManager;

        public CommandLoadUIController(ICommandManager commandManager, GameObject backGround, Slider sliderCountProgress)
        {
            _commandManager = commandManager;
            _backGround = backGround;
            _sliderCountProgress = sliderCountProgress;

            _commandManager.OnStartExecute += StartCommandsExecute;
            _commandManager.OnFinishOneExecute += FinishOneCommandUpdate;
            _commandManager.OnFinishAllExecute += FinishAllCommandExecute;
        }

        private void StartCommandsExecute()
        {
            _backGround.SetActive(true);

            _sliderCountProgress.maxValue = _commandManager.GetMaxCountExecuteCommand();
            _sliderCountProgress.value = 0;
        }

        private void FinishOneCommandUpdate(int newValueIndex)
        {
            _sliderCountProgress.value = newValueIndex;
        }

        private void FinishAllCommandExecute()
        {
            _backGround.SetActive(false);
        }
    }
}
