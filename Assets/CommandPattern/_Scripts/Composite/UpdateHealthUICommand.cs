using System.Threading.Tasks;
using UnityEngine;
using System;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class UpdateHealthUICommand : ICommand {

        public async Task Execute() {

            Debug.Log("UI Actualizada");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}