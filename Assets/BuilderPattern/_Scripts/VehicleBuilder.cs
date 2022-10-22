using System.Collections.Generic;
using UnityEngine;

namespace PatronesDeDiseño.BuilderPattern {

    public class VehicleBuilder {

        private Chassis _chassis;
        private Vehicle _vehicle;
        private readonly Dictionary<TyrePosition, Tyre> _tyresDict = new Dictionary<TyrePosition, Tyre>();

        private Vector3 _position = new Vector3(1f, 2f, 3f);
        private Quaternion _rotation;

        /*
            Al devolver una instancia de la clase se pueden usar los métodos de la instancia de la clase.
            Lo que en pocas palabras significa porder encadenar los métodos :)
        */

        public VehicleBuilder WithChassis(Chassis chassis) { 
            _chassis = chassis;
            return this;
        }

        public VehicleBuilder WithTyre(TyrePosition tyrePosition, Tyre tyre) {
            _tyresDict.Add(tyrePosition, tyre);
            return this;
        }

        public VehicleBuilder WithPosition(Vector3 position) {
            _position = position;
            return this;
        }
        
        public VehicleBuilder WithRotation(Quaternion rotation) {
            _rotation = rotation;
            return this;
        }

        public VehicleBuilder FromVechilePrefab(Vehicle newVehicle) {
            _vehicle = newVehicle;
            return this;
        }

        public Vehicle Build() {
            
            var vehicle = Object.Instantiate(_vehicle, _position, _rotation);
            var chassis = Object.Instantiate(_chassis, vehicle.transform, true); 
            var tyres = new Dictionary<TyrePosition, Tyre>();

            foreach (var tyre in _tyresDict) {
                
                var tyreInstance = Object.Instantiate(tyre.Value, chassis.GetTyrePostition(tyre.Key));

                tyres.Add(tyre.Key, tyreInstance);
            }

            vehicle.SetComponents(tyres, chassis);

            return vehicle;
        }
    }

    
    public class VechileBuilderConsumer : MonoBehaviour {

        private void Awake() {

            var vehicle = new VehicleBuilder()
                                .WithPosition(new Vector3(0f, 0f, 0f))
                                .WithTyre(TyrePosition.FrontLeft, null)
                                .WithTyre(TyrePosition.FrontRight, null)
                                .Build();

            var vehicle2 = new VehicleBuilder();

            vehicle2.WithPosition(new Vector3(0f, 1f, 0f))
                    .WithTyre(TyrePosition.FrontRight, null)
                    .WithTyre(TyrePosition.FrontLeft, null)
                    .WithTyre(TyrePosition.BackLeft, null)
                    .WithTyre(TyrePosition.BackRight, null)
                    .Build();

            vehicle2.WithPosition(new Vector3(0f, 2f, 0f))
                    .Build();
        }
    }
}

