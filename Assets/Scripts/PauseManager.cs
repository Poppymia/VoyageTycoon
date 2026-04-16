using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu; // Drag your PauseMenu prefab here
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape pressed!");
            TogglePause();
        }
    }

    // This was the missing piece!
    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        if (pauseMenu != null) pauseMenu.SetActive(false);
        Time.timeScale = 1f; 
        isPaused = false;
    }

    void Pause()
    {
        if (pauseMenu != null) pauseMenu.SetActive(true);
        Time.timeScale = 0f; 
        isPaused = true;
    }
}