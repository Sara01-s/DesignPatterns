using System.Threading.Tasks;
using UnityEngine;
using System;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class CameraShakeCommand : ICommand {

        public async Task Execute() {

            Debug.Log("Increible shake");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}