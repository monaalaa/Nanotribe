using Managers;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreController : MonoBehaviour
    {
        private readonly ScoreModel _model = new ScoreModel();
        [SerializeField] private ScoreView view;
        private void Awake()
        {
            EventsManager.UpdateScore += UpdateScore;
        }
        private void UpdateScore(int newScore)
        {
            _model.Score += newScore;
            if (_model.Score < 0)
            {
                _model.Score = 0;
            }
            
            view.UpdateScore(_model.Score);
        }
        private void OnDestroy()
        {
            EventsManager.UpdateScore -= UpdateScore;
        }
    }
}
