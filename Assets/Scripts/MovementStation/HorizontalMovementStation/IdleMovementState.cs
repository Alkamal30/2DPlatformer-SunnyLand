using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace SunnyLandGame {

    class IdleMovementState : BaseMovementState {

        public IdleMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {
        
        }


        public override void OnLeftMovementStart() {
            _entity.Movement.Direction = MovementDirection.LEFT;
            _entity.Animator.StartRunAnimation();
            _switcher.SwitchState<LeftMovementState>();
        }

        public override void OnRightMovementStart() {
            _entity.Movement.Direction = MovementDirection.RIGHT;
            _entity.Animator.StartRunAnimation();
            _switcher.SwitchState<RightMovementState>(); 
        }

    }
}
