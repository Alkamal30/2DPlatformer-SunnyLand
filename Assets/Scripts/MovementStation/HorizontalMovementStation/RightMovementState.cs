using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


namespace SunnyLandGame {

    class RightMovementState : BaseMovementState {
        
        public RightMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {
        
        }


        public override void OnLeftMovementStart() {
            _entity.Movement.Direction = MovementDirection.LEFT;
            _switcher.SwitchState<LeftMovementState>();
        }

        public override void OnRightMovementEnd() {
            _entity.Movement.Direction = MovementDirection.IDLE;
            _entity.Animator.StartIdleAnimation();
            _switcher.SwitchState<IdleMovementState>();
        }
    }
}
