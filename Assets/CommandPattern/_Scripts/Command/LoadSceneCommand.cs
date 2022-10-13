using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine;

namespace PatronesDeDiseño.CommandPattern {

    public sealed class LoadSceneCommand : ICommand {

        private readonly string _sceneName;

        public LoadSceneCommand(string sceneName) {
            _sceneName = sceneName;
        }

        public async Task Execute() {

            AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(_sceneName);

            while (!asyncOperation.isDone) {
                await Task.Yield();
            }
        }
    }    
}