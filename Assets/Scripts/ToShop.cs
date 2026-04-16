using UnityEngine;
using UnityEngine.SceneManagement; // Essential for switching scenes

public class SceneSwitcher : MonoBehaviour
{
    // This allows you to type the scene name in the Inspector
    public string shopSceneName;

    public void GoToShop()
    {
        // Check if the string isn't empty before trying to load
        if (!string.IsNullOrEmpty(shopSceneName))
        {
            SceneManager.LoadScene(shopSceneName);
        }
        else
        {
            Debug.LogError("Shop scene name is missing in the Inspector!");
        }
    }
}