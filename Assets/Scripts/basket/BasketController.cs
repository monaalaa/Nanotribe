using Commands;
using UnityEngine;
namespace basket
{
    public class BasketController : MonoBehaviour
    {
       [SerializeField] private BasketModel data = new BasketModel();
       private const float YPos = 15.0f;
       private MoveCommand _command;
       private void Update()
       {
#if !UNITY_EDITOR
            ExecuteTouch();
#else
           ExecuteEditor();
#endif
       }
       private void ExecuteTouch()
       {
           if (Input.touchCount > 0)
           {
               Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
 
               if (touchDeltaPosition.x < 0.0f)
               {
                   MoveToLeft();
               }
               else if (touchDeltaPosition.x > 0.0f)
               {
                   MoveToRight();
               }
               var xPos = Mathf.Clamp(transform.localPosition.x, data.leftLimit, data.rightLimit);
               transform.position = new Vector3(xPos, YPos, 0.0f);
           }
       }
       //Note ExecuteEditor function just for testing in editor
       private void ExecuteEditor()
       {
           if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
           {
               MoveToLeft();
           }
           else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
           {
              MoveToRight();
           }
           var xPos = Mathf.Clamp(transform.localPosition.x, data.leftLimit, data.rightLimit);
           transform.position = new Vector3(xPos, YPos, 0.0f);
       }
       private void MoveToRight()
       {
           _command = new MoveCommand(transform,data.speed,Vector3.right);
           _command.Execute();
       }
       private void MoveToLeft()
       {
           _command = new MoveCommand(transform,data.speed,Vector3.left);
           _command.Execute();
       }
    }
}
