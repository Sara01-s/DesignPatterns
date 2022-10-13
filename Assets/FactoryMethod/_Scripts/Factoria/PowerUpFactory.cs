namespace PatronesDeDiseño.FactoryMethod {

    public sealed class PowerUpFactory {

        private readonly PowerUpSO _powerUpConfiguration;

        public PowerUpFactory(PowerUpSO powerUpConfiguration) {
            _powerUpConfiguration = powerUpConfiguration;
        }

        public PowerUp Create(string id) {

            var powerUp = _powerUpConfiguration.GetPowerUpPrefabById(id);

            return UnityEngine.Object.Instantiate(powerUp);

            // ^^^^^^^^^^^^^^^^^^^
            // Reemplazaa esto:
            /*switch (id) {
                case "Speed":
                    return Instantiate(_speedPowerUp);
                case "Drunk":
                    return Instantiate(_drunkPowerUp);
                default:
                    throw new ArgumentOutOfRangeException($"Power Up with id {id} does not exist.");
            }*/
        }
    }
}