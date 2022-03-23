using Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameOver
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private GameOverView view;
        private void Awake()
        {
            EventsManager.GameOver += OnGameOver;
            view.OnReload += Reload;
        }
        private void OnGameOver()
        {
            view.EnableGameOverPanel();
        }
        private void Reload()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        private void OnDestroy()
        {
            EventsManager.GameOver -= OnGameOver;
            view.OnReload -= Reload;
        }
    }
}
