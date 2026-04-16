using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenuUI; // Drag your Prefab here in the Inspector
    private bool isPaused = false;

    void Update()
    {
        // Toggle pause with the Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) Resume();
            else Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Unfreezes the game
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Freezes the game world
        isPaused = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // CRITICAL: Reset time before switching scenes
        SceneManager.LoadScene("MainMenu");
    }
}