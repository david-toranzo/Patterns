using Toranzo.Installer;
using UnityEngine;

namespace Patterns.Command
{
    public class CommandManagerInstaller : MonoInstaller<ICommandManager>
    {
        [SerializeField] private BaseCommand[] _commands;

        protected override ICommandManager GetDataType()
        {
            /*ICommand[] commands = new ICommand[_commands.Length];

            for (int i = 0; i < _commands.Length; i++)
            {
                commands[i] = _commands[i].Data;
            }*/

            return new CommandManager(_commands);
        }
    }
}