using UnityEngine;

namespace Core
{
    /// <summary>
    /// Main game manager that handles core game functionality
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [Header("Game Settings")]
        [SerializeField] private bool isGamePaused = false;
        [SerializeField] private float gameTime = 0f;

        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            // Singleton pattern
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            InitializeGame();
        }

        private void Update()
        {
            if (!isGamePaused)
            {
                gameTime += Time.deltaTime;
            }
        }

        private void InitializeGame()
        {
            Debug.Log("Game initialized successfully!");
        }

        public void PauseGame()
        {
            isGamePaused = true;
            Time.timeScale = 0f;
        }

        public void ResumeGame()
        {
            isGamePaused = false;
            Time.timeScale = 1f;
        }

        public float GetGameTime()
        {
            return gameTime;
        }
    }
}
