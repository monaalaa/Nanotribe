using System;
using UnityEngine;

namespace GameOver
{
    public class GameOverView : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;
        public Action OnReload;
        public void EnableGameOverPanel()
        {
            gameOverPanel.SetActive(true);
        }
        public void Reload()
        {
            OnReload?.Invoke();
        }
    }
}
