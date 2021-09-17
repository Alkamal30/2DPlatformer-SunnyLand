using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace SunnyLandGame {
    public abstract class MovementStation : MonoBehaviour, IMovementStationSwitcher {

        [SerializeField] protected Entity _entity;

        protected List<BaseMovementState> _statesList;
        protected BaseMovementState _currentState;


        public void SwitchState<T>() where T : BaseMovementState {
            var state = _statesList.FirstOrDefault(s => s is T);
            _currentState = state; 
        }
    }
}
