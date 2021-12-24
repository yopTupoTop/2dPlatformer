using System;
using Input;
using UnityEngine;

namespace Player
{
    public class MovementController : MonoBehaviour
    {
        public CharacterController CharacterController;
        private float MovementSpeed;
        private IInput _input;

        private void Awake()
        {
            _input = GameManager.Input;
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;
            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }
        
    }
}