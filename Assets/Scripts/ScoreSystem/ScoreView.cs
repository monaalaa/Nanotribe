using TMPro;
using UnityEngine;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text score;
        public void UpdateScore(int newScore)
        {
            //Note: the Score word should be a key for Localization
            score.text = $"Score: {newScore}";
        }
    }
}
