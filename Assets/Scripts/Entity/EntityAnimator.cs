using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace SunnyLandGame {

    public class EntityAnimator : MonoBehaviour {

        [SerializeField] private Animator _animator = null;

        private int _runStateHash = Animator.StringToHash("IsMove");
        private int _jumpStateHash = Animator.StringToHash("IsJump");
        private int _landedStateHash = Animator.StringToHash("Landed");

        public void StartRunAnimation() {
            _animator.SetBool(_runStateHash, true);
        }

        public void StartIdleAnimation() {
            _animator.SetBool(_runStateHash, false);
        }

        public void StartJumpAnimation() {
            _animator.SetBool(_jumpStateHash, true);
        }

        public void StartFallAnimation() {
            _animator.SetBool(_jumpStateHash, false);
        }

        public void FinishFallAnimation() {
            _animator.SetTrigger(_landedStateHash);
        }

    }
}
