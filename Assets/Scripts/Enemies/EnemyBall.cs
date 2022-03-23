using Behaviours;
using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyBall : Collidable,IEnemy
    {
        [SerializeField]  private int changeScoreBy = -1;
        private void Awake()
        {
            OnCollision += EffectPlayer;
        }
        public void EffectPlayer()
        {
            EventsManager.UpdateScore?.Invoke(changeScoreBy);
        }
    }
}
