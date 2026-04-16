using UnityEngine;

public class HouseClick : MonoBehaviour
{
    public GameObject speechBubble; // Drag your Canvas here in the Inspector

    void OnMouseDown()
    {
        // This toggles the bubble on/off when you click
        speechBubble.SetActive(!speechBubble.activeSelf);
    }
}