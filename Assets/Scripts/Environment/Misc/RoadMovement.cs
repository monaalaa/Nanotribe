using System;
using Commands;
using UnityEngine;

namespace Environment.Misc
{
    public class RoadMovement : MonoBehaviour
    {
        //Note: we can multiply speed with factor based on level to make game faster 
        public int speed = 25;
        private readonly Vector3 _direction = -Vector3.forward;
        private MoveCommand _command;
        private void Start()
        {
            _command=new MoveCommand(transform);
        }
        private void Update()
        {
            _command.UpdateMovementProperties(speed,_direction);
            _command.Execute();
        }
    }
}
