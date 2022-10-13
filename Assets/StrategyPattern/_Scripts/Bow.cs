using UnityEngine;

namespace PatronesDeDiseño.StrategyPattern {

    public sealed class Bow : MonoBehaviour, IWeapon {

        public void Attack() {
            Debug.Log("Atacas con arco");
        }

    }
}