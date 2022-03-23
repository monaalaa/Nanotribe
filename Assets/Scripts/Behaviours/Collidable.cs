using System;
using UnityEngine;

namespace Behaviours
{
    public abstract class Collidable : MonoBehaviour
    {
        private const string BasketTag = "Basket";
        protected Action OnCollision;
       
        //Note: i make this ApplyEffect like that so if any other collidable do
        //especial  effect can be applied here by overload this function
        protected virtual void ApplyEffect()
        {
            Destroy(gameObject);
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(BasketTag))
            {
                OnCollision?.Invoke();
                ApplyEffect();
            }
        }
    }
}
