using Behaviours;
using Managers;
using UnityEngine;

namespace Collectables
{
    public class CollectableBall : Collidable,ICollectable
    {
        [SerializeField]  private int changeScoreBy = 1;
        private void Awake()
        {
            OnCollision += CollectItem;
        }
        public void CollectItem()
        {
            EventsManager.UpdateScore?.Invoke(changeScoreBy);
        }
    }
}
