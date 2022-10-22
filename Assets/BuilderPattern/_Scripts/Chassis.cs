using UnityEngine;
using System;

namespace PatronesDeDiseño.BuilderPattern {

    public abstract class Chassis : MonoBehaviour {


        [SerializeField]
        private Transform _frontRightTyrePostion, _frontLeftTyrePostion, _backRightTyrePostion, _backLeftTyrePostion;

        public Transform GetTyrePostition(TyrePosition position) {

            switch (position) {
                case TyrePosition.FrontLeft:

                break;

                case TyrePosition.FrontRight:
                break;

                case TyrePosition.BackLeft:
                break;

                case TyrePosition.BackRight:
                break;
            }

            throw new ArgumentOutOfRangeException(nameof(position), position, null);
        }

        protected abstract void OnCollisionEnter(Collision other);
    }
}