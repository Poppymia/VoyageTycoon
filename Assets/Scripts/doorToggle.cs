using UnityEngine;
using UnityEngine.SceneManagement; // This line is required to switch scenes

public class DoorToggle : MonoBehaviour
{
    public Sprite closedSprite;
    public Sprite openSprite;
    public string sceneToLoad; // Type the name of the next scene here
    
    private SpriteRenderer spriteRenderer;
    private bool isOpen = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closedSprite;
    }

    void OnMouseDown()
    {
        // Only trigger if the door isn't already open
        if (!isOpen)
        {
            OpenDoorAndLeave();
        }
    }

    void OpenDoorAndLeave()
    {
        isOpen = true;
        spriteRenderer.sprite = openSprite;

        // Load the scene. 
        // If you want a tiny delay so the player sees the door open, 
        // you could use Invoke("ChangeScene", 0.5f);
        ChangeScene();
    }

    void ChangeScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("You forgot to type the scene name in the Inspector!");
        }
    }
}