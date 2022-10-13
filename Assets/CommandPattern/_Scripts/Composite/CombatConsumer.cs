using UnityEngine;

namespace PatronesDeDiseño.CommandPattern {
    
    public sealed class CombatConsumer : MonoBehaviour {

        private void Update() {

            if (Input.GetKeyDown(KeyCode.F1)) {
                
                // Con composite (como las secuencias de DOTween :O)
                var _compositeCommand = new CompositeCommand();

                _compositeCommand.AddCommand(new DoDamageCommand());
                _compositeCommand.AddCommand(new CameraShakeCommand());
                _compositeCommand.AddCommand(new UpdateHealthUICommand());

                CommandQueue.Instance.AddCommand(_compositeCommand);

                /* Ahora todos los comandos se realizarán a la vez, sin embargo el Task
                   esperará a que TODOS TERMINEN en lugar de uno por uno.

                Sin composite sería:
                CommandQueue.Instance.AddCommand(new DoDamageCommand());
                CommandQueue.Instance.AddCommand(new CameraShakeCommand());
                CommandQueue.Instance.AddCommand(new UpdateHealthUICommand());
                
                En este caso, los comandos esperarán su respectivo tiempo poara ejecutarse en cadena
                */
            }
        }
    }
}