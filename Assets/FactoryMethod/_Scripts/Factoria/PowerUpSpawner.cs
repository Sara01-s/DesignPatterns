using UnityEngine;

namespace PatronesDeDiseño.FactoryMethod {
    
    public sealed class PowerUpSpawner : MonoBehaviour {
        
        [SerializeField] private PowerUpSO _powerUpConfiguration;

        private PowerUpFactory _powerUpFactory;

        private void Awake() {                // Instantiate para que se llame el Awake() del SO
            _powerUpFactory = new PowerUpFactory(Instantiate(_powerUpConfiguration));
        }

        private void Update() {
            
            foreach (var powerUp in _powerUpConfiguration.PowerUps) {
                SpawnPowerUP(powerUp.SpawnKey, powerUp.Id);
            }   
        }

        private void SpawnPowerUP(KeyCode powerUpInputKey, string id) {

            if (Input.GetKeyDown(powerUpInputKey)) {
                _powerUpFactory.Create(id); 
            }
        }
    }
}