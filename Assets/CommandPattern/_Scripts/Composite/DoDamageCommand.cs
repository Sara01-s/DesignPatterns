using System.Threading.Tasks;
using UnityEngine;
using System;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class DoDamageCommand : ICommand {

        public async Task Execute() {

            Debug.Log("Daño realizado! whoosh");
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}