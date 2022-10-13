using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class CompositeCommand : ICommand {

        private List<ICommand> commands = new List<ICommand>();

        public CompositeCommand() {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command) {
            commands.Add(command);
        }

        public async Task Execute() {

            var tasks = new List<Task>();

            commands.ForEach(command => tasks.Add(command.Execute()));

            await Task.WhenAll(tasks);
        }
    }
}