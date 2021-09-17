using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;


namespace SunnyLandGame {
    public class EntityMovementHandler : MonoBehaviour {

        public UnityEvent OnEntityFall;
        public UnityEvent OnEntityLanded;


        private Rigidbody2D _rigidbody;

        private void Start() {
            _rigidbody = GetComponent<Rigidbody2D>();
        }


        private void Update() {
            CheckEntityOnFall(); 
        }

        private void OnCollisionEnter2D(Collision2D collision) {
            if(collision.transform.CompareTag("Ground")) {
                OnEntityLanded.Invoke();
            }
        }

        private void CheckEntityOnFall() {
            if(_rigidbody.velocity.y < 0f)
                OnEntityFall.Invoke();
        }

    }
}
