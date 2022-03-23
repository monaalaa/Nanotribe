using System;
using UnityEngine;

namespace Behaviours
{
    public abstract class Collidable : MonoBehaviour
    {
        private const string BasketTag = "Basket";
        protected Action OnCollision;
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
