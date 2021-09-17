using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;


namespace SunnyLandGame {

    public enum MovementDirection {
        LEFT = -1,
        IDLE = 0,
        RIGHT = 1
    }

    public class EntityMovement : MonoBehaviour {

        public MovementDirection Direction;


        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _jumpForce;

        private Rigidbody2D _entityRigidbody;

        private SpriteRenderer _spriteRenderer;


        private void Start() {
            _entityRigidbody = GetComponent<Rigidbody2D>();
            Direction = MovementDirection.IDLE;

            _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
        }

        private void Update() {
            MoveEntity();
            SpriteFlipper();
            
        }



        public void Jump() {
            float entityMass = _entityRigidbody.mass;
            Vector2 jumpForceVector = Vector2.up * _jumpForce * entityMass;

            _entityRigidbody.AddForce(jumpForceVector, ForceMode2D.Impulse);
        }

        private void MoveEntity() {
            Vector2 entityVelocity = _entityRigidbody.velocity;
            entityVelocity.x = (float)Direction * _movementSpeed;
            _entityRigidbody.velocity = entityVelocity;
        }



        private void SpriteFlipper() {
            switch(Direction) {
                case MovementDirection.LEFT:
                    _spriteRenderer.flipX = true;
                    break;
                case MovementDirection.RIGHT:
                    _spriteRenderer.flipX = false;
                    break;
            }
        }
    }
}
