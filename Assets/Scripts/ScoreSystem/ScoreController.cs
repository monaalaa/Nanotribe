using Managers;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreController : MonoBehaviour
    {
        private ScoreModel Model = new ScoreModel();
        [SerializeField] private ScoreView view;
        private void Awake()
        {
            EventsManager.UpdateScore += UpdateScore;
        }
        private void UpdateScore(int newScore)
        {
            Model.Score += newScore;
            if (Model.Score < 0)
            {
                Model.Score = 0;
            }
            
            view.UpdateScore(Model.Score);
        }
        private void OnDestroy()
        {
            EventsManager.UpdateScore -= UpdateScore;
        }
    }
}
