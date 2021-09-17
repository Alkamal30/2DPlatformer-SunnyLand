using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace SunnyLandGame {
    
    public abstract class BaseMovementState {

        protected readonly Entity _entity;
        protected readonly IMovementStationSwitcher _switcher;


        protected BaseMovementState(Entity entity, IMovementStationSwitcher switcher) {
            _entity = entity;
            _switcher = switcher;
        }

        public virtual void OnLeftMovementStart() {
        
        }

        public virtual void OnLeftMovementEnd() {
        
        }

        public virtual void OnRightMovementStart() {
        
        }

        public virtual void OnRightMovementEnd() {
        
        }

        public virtual void OnJump() {
        
        }

        public virtual void OnFall() {
        
        }

        public virtual void OnLand() {
        
        }

    }

}
