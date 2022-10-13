using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatronesDeDiseño.CommandPattern
{

    public sealed class CommandQueue {

        private readonly Queue<ICommand> _commandsToExecuteQueue;
        public static CommandQueue _instance;
        private bool _runningCommand;

        public static CommandQueue Instance => _instance ?? (_instance = new CommandQueue());

        private CommandQueue() {
            _commandsToExecuteQueue = new Queue<ICommand>();
            _runningCommand = false;
        }

        public void AddCommand(ICommand command) {
            _commandsToExecuteQueue.Enqueue(command);
            RunNextCommand().WrapErrors();
        }

        public async Task RunNextCommand() {
            
            if (_runningCommand) return;

            while (_commandsToExecuteQueue.Count > 0) {
                _runningCommand = true;

                var commandToExecute = _commandsToExecuteQueue.Dequeue();

                await commandToExecute.Execute();
            }

            _runningCommand = false;
        }
    }

    public static class TaskExtensions {

        public static async void WrapErrors(this Task task) {
            await task;
        }
    }
}