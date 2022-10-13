using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class Menu2 : MonoBehaviour {

        [SerializeField] private Button _loadNextMenuButton;

        [SerializeField] private CanvasGroup _canvasGroup2;

        private List<ICommand> _commands = new List<ICommand>();

        private void Awake() {
            _loadNextMenuButton.onClick.AddListener(LoadNextScene);
        }

        private void LoadNextScene() {
            _commands.ForEach(command => CommandQueue.Instance.AddCommand(command));
        }

        public void ConfigureCommands(List<ICommand> commands) {
            _commands = commands;
        }
    }
}