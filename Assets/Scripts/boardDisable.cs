using UnityEngine;

public class boardDisable : MonoBehaviour
{
     // Drag the board object (or the whole Canvas) into this slot in the Inspector
    public GameObject introBoard;

    public void CloseIntro()
    {
        introBoard.SetActive(false);
    }
}


