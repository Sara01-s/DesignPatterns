using UnityEngine;

namespace PatronesDeDiseño.FactoryMethod {

    public abstract class PowerUp : MonoBehaviour {
        [SerializeField] private KeyCode _spawnKey;
        [SerializeField] private string _id;

        public KeyCode SpawnKey { get {
            return _spawnKey;
        }}

        public string Id { get {
            return _id;
        }}
    }
}