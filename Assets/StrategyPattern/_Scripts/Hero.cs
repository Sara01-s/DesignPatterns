using UnityEngine;

namespace PatronesDeDiseño.StrategyPattern {

    public sealed class Hero : MonoBehaviour {

        public IWeapon _weapon;

        private void Update() {

            if (Input.GetKeyDown(KeyCode.Space)) {
                _weapon.Attack();
            }
        }

        public void SetWeapon(IWeapon weapon) {
            _weapon = weapon;
        }
    }
}