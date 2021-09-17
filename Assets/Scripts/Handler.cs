using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


namespace SunnyLandGame {

    class Handler : MonoBehaviour {

        public UnityEvent OnLeftButtonDown;
        public UnityEvent OnLeftButtonUp;
        public UnityEvent OnRightButtonDown;
        public UnityEvent OnRightButtonUp;
        public UnityEvent OnJumpButtonDown;


        private void Update() {

            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
                OnLeftButtonDown.Invoke();
            if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
                OnLeftButtonUp.Invoke();
            if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
                OnRightButtonDown.Invoke();
            if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
                OnRightButtonUp.Invoke();
            if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                OnJumpButtonDown.Invoke();
        }

    }
}
