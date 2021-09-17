using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace SunnyLandGame {
    class VerticalMovementStationBehaviour : MovementStation {

        private void Start() {
            _statesList = new List<BaseMovementState> { 
                new GroundedMovementState(_entity, this),
                new JumpMovementState(_entity, this),
                new FallMovementState(_entity, this)
            };

            _currentState = _statesList[0];
        }

        public void OnJump() {
            _currentState.OnJump(); 
        }

        public void OnFall() {
            _currentState.OnFall();
        }

        public void OnLand() {
            _currentState.OnLand();
        }
    }
}
