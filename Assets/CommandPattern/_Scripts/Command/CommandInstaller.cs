using System.Collections.Generic;
using UnityEngine;
using System;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class CommandInstaller : MonoBehaviour {
        
        [SerializeField] private Menu1 _menu1;
        [SerializeField] private Menu2 _menu2;

        [SerializeField] private CanvasGroup _canvasGroup1;
        [SerializeField] private CanvasGroup _canvasGroup2;

        private void Awake() {

            var menu1CommandList = new List<ICommand>() {
                new CanvasGroupFaderCommand(_canvasGroup1, 0, 0.5f),
                new CanvasGroupFaderCommand(_canvasGroup2, 1, 0.5f)
            };

            _menu1.ConfigureCommands(menu1CommandList);

            var menu2CommandList = new List<ICommand>() {
                new CanvasGroupFaderCommand(_canvasGroup2, 0, 0.5f),
                new LoadSceneCommand("Game")
            };

            _menu2.ConfigureCommands(menu2CommandList);
        }
    }
}