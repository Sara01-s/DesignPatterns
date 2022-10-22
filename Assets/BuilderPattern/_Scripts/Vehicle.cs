using System.Collections.Generic;
using UnityEngine;

namespace PatronesDeDiseño.BuilderPattern {
    
    public class Vehicle : MonoBehaviour {

        private Dictionary<TyrePosition, Tyre> _tyresDict;
        private Chassis _chassis;

        public void SetComponents(Dictionary<TyrePosition, Tyre> tyresDict, Chassis chassis) {
            _tyresDict = tyresDict;
            _chassis = chassis;
        }
    }
}