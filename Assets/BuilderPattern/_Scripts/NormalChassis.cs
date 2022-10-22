using UnityEngine;

namespace PatronesDeDiseño.BuilderPattern {
    
    public class NormalChassis : Chassis {
        
        protected override void OnCollisionEnter(Collision other) {
            // Perder vida si colisiona
            Debug.Log("Ouch!");
        }
    }
}