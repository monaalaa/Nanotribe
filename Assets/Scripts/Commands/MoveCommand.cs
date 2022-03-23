using UnityEngine;

namespace Commands
{
    public class MoveCommand
    {
       private readonly Transform _moved;
       private readonly float _speed;
       private readonly Vector3 _direction;
 
        public MoveCommand(Transform target, float speed, Vector3 direction)
        {
            _moved = target;
            _speed = speed;
            _direction = direction;
        }
        public void Execute()
        {
            _moved.Translate(_direction * _speed * Time.deltaTime);
        }
    }
}
