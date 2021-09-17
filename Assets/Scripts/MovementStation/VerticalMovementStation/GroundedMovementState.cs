using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace SunnyLandGame {
    class GroundedMovementState : BaseMovementState {
    
        public GroundedMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {

        }

        public override void OnJump() {
            _entity.Movement.Jump();
            _entity.Animator.StartJumpAnimation();
            _switcher.SwitchState<JumpMovementState>();
        }
    }
}
