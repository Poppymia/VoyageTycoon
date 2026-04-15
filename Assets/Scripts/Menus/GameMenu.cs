using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
 [SerializeField] private String gameSceneName;

    public void Play()
    {
        SceneManager.LoadScene(gameSceneName);
    }

public void Quit()
    {
        Application.Quit();
    }
}
