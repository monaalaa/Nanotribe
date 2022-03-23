using Managers;
using UnityEngine;

namespace Environment.Misc
{
    public class EndOfLevelTrigger : MonoBehaviour
    {
        private const string BasketTag = "Basket";
        private void OnTriggerEnter(Collider trigger)
        {
            if (trigger.gameObject.CompareTag(BasketTag))
            {
                Time.timeScale = 0;
                EventsManager.GameOver?.Invoke();
            }
        }
    }
}
