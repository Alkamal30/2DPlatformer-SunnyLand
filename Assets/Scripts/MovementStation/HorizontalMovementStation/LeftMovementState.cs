using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


namespace SunnyLandGame {

    class LeftMovementState : BaseMovementState {
    
        public LeftMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {
        
        }

        public override void OnLeftMovementEnd() {
            _entity.Movement.Direction = MovementDirection.IDLE;
            _entity.Animator.StartIdleAnimation();
            _switcher.SwitchState<IdleMovementState>();
        }

        public override void OnRightMovementStart() {
            _entity.Movement.Direction = MovementDirection.RIGHT;
            _switcher.SwitchState<RightMovementState>();
        }

    
    }
}
