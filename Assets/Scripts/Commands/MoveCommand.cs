using UnityEngine;

namespace Commands
{
    public class MoveCommand
    {
       private readonly Transform _moved;
       private float _speed;
       private Vector3 _direction;
 
        public MoveCommand(Transform target)
        {
            _moved = target;
        }
        public void UpdateMovementProperties( float speed, Vector3 direction)
        {
            _speed = speed;
            _direction = direction;
        }
        public void Execute()
        {
            _moved.Translate(_direction * _speed * Time.deltaTime);
        }
    }
}
