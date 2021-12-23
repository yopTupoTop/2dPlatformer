using UnityEngine;

namespace Player
{
    public class MovementController : IMove
    {
        private Rigidbody2D _rigidbody;
        private float _speed;
        
        public MovementController(Rigidbody2D rigidbody, float speed)
        {
            _speed = speed;
            _rigidbody = rigidbody;
        }
        
        public void Move()
        {
            
        }

        public void Jump()
        {
            
        }
    }
}