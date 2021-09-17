using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace SunnyLandGame {
    class JumpMovementState : BaseMovementState {
    
        public JumpMovementState(Entity entity, IMovementStationSwitcher switcher)
            : base(entity, switcher) {

        }


        public override void OnFall() {
            _entity.Animator.StartFallAnimation();
            _switcher.SwitchState<FallMovementState>();
        }
    }
}
