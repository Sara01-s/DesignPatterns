using UnityEngine;

namespace PatronesDeDiseño.StrategyPattern {

    public sealed class Installer : MonoBehaviour {

        [SerializeField] private Hero _heroPrefab;
        [SerializeField] private Sword _swordPrefab;
        [SerializeField] private Bow _bowPrefab;

        [SerializeField] private bool _useSword;

        private void Awake() {
            
            var hero = Instantiate(_heroPrefab);
            var weapon = GetWeapon(hero.transform);
            hero.SetWeapon(weapon);
        }

        private IWeapon GetWeapon(Transform parent) {

            if (_useSword) {
                return Instantiate(_swordPrefab, parent);
            }
            else {
                return Instantiate(_bowPrefab, parent);
            }
        }
    }
}