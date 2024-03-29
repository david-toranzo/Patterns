﻿using System;
using System.Collections.Generic;

namespace Patterns.Command
{
    public class CommandManager : ICommandManager
    {
        private readonly List<ICommandWithManager> _commands;

        public Action OnStartExecute { get; set; }
        public Action OnFinishAllExecute { get; set; }
        public Action<int> OnFinishOneExecute { get; set; }

        protected int _commandInternalCount = 0;

        public CommandManager(ICommandWithManager[] commands)
        {
            _commands = new List<ICommandWithManager>();

            foreach (ICommandWithManager nodeCommander in commands)
            {
                nodeCommander.SetCommandManager(this);
                _commands.Add(nodeCommander);
            }
        }

        public void StartMakeCommandAction()
        {
            OnStartExecute.Invoke();

            _commandInternalCount = 0;

            DoneExecutionCommand();
        }

        public void DoneExecutionCommand()
        {
            OnFinishOneExecute?.Invoke(_commandInternalCount);

            if (_commandInternalCount >= _commands.Count)
            {
                FinishAllExecutionCommand();
                return;
            }

            RunNextCommand();
        }

        public void RunNextCommand()
        {
            _commands[_commandInternalCount].Execute();
            _commandInternalCount++;
        }

        private void FinishAllExecutionCommand()
        {
            OnFinishAllExecute?.Invoke();
        }

        public int GetMaxCountExecuteCommand() => _commands.Count;
    }
}