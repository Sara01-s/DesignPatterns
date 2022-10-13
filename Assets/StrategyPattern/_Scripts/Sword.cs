using UnityEngine;

namespace PatronesDeDiseño.StrategyPattern {

    public sealed class Sword : MonoBehaviour, IWeapon {

        public void Attack() {
            Debug.Log("Atacas con espada");
        }
        
    }
}