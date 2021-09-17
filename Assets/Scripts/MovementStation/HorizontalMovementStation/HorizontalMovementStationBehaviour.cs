using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SunnyLandGame {
    public class HorizontalMovementStationBehaviour : MovementStation {

        private void Start() {
            _statesList = new List<BaseMovementState> {
                new IdleMovementState(_entity, this),
                new LeftMovementState(_entity, this),
                new RightMovementState(_entity, this)
            };

            _currentState = _statesList[0];
        }

        
        public void OnLeftMovementStart() {
            _currentState.OnLeftMovementStart();
        }

        public void OnLeftMovementEnd() {
            _currentState.OnLeftMovementEnd();
        }

        public void OnRightMovementStart() {
            _currentState.OnRightMovementStart();
        }

        public void OnRightMovementEnd() {
            _currentState.OnRightMovementEnd();
        }
    }
}
