using System;
using Input;
using UnityEngine;

namespace Character.Options
{
    public class PlayerMovementController : MonoBehaviour, IMove
    {
        public CharacterController CharacterController;
        private float MovementSpeed;
        private IInput _input;
        private Camera _camera;

        private void Awake()
        {
            _input = GameManager.Input;
        }
        
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            Move();
        }

        public void Move()
        {
            Vector3 movementVector = Vector3.zero;

            if (_input.Axis.sqrMagnitude > 0.001f)
            {
                movementVector = _camera.transform.TransformDirection(_input.Axis);
                movementVector.z = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;
            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }
}