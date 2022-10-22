using UnityEngine;

namespace PatronesDeDiseño.BuilderPattern {
    
    public class ExplosiveChassis : Chassis {

        protected override void OnCollisionEnter(Collision other) {
            // Explota si colisiona
            Debug.Log("Boom!");
        }
    }
}