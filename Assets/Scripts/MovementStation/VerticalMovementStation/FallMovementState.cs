using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace SunnyLandGame {
    class FallMovementState : BaseMovementState {
    
        public FallMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {

        }


        public override void OnLand() {
            _entity.Animator.FinishFallAnimation();
            _switcher.SwitchState<GroundedMovementState>();
        }
    }
}
