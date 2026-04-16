using UnityEngine;
using UnityEngine.SceneManagement; // Required for changing scenes

public class HouseClick : MonoBehaviour
{
    // Type the exact name of your next scene here (e.g., "HotelInterior")
    public string sceneToLoad; 

    void OnMouseDown()
    {
        // This will load the scene specified in the Inspector
        SceneManager.LoadScene(sceneToLoad);
    }
}