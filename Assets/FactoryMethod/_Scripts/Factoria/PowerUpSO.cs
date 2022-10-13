using System.Collections.Generic;
using UnityEngine;
using System;

namespace PatronesDeDiseño.FactoryMethod {

    [CreateAssetMenu(menuName = "Game/Power up configuration")]
    public sealed class PowerUpSO : ScriptableObject {

        /* Evitar
        [SerializeField] private PowerUp _speedPowerUp;
        [SerializeField] private PowerUp _drunkPowerUp;*/

        // Con esto se cumple el principio Open/Close de SOLID
        [SerializeField] private PowerUp[] _powerUps;
        
        public PowerUp[] PowerUps { get {
            return _powerUps;
        }}

        private Dictionary<string, PowerUp> _powerUpDictionary;

        private void Awake() {
            _powerUpDictionary = new Dictionary<string, PowerUp>();

            foreach (var powerUp in _powerUps) {
                _powerUpDictionary.Add(powerUp.Id, powerUp);
            }
        }

        public PowerUp GetPowerUpPrefabById(string id) {
            //PowerUp powerUp;                      // outline
                                                    // inline
            if (!_powerUpDictionary.TryGetValue(id, out var powerUp)) {
                throw new Exception($"PowerUp {id} does not exist");
            }

            return powerUp;
        }
    }
    
}