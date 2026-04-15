using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject movePopup;
    public GameObject tapPopup;
    public GameObject arrow;
    public CameraMove cameraMove;

    private bool hasMoved = false;
    private bool chestOpened = false;

    void Start()
    {
        movePopup.SetActive(true);
        tapPopup.SetActive(false);
        arrow.SetActive(false);
    }
    
    void Update()
    {
        //detect movement 
        if (!hasMoved && Input.GetAxis("Horizontal") != 0)
        {
            hasMoved = true;
            movePopup.SetActive(false);
            tapPopup.SetActive(true);
        }
    }

    public void OnChestOpened()
    {
        chestOpened = true;
        tapPopup.SetActive(false);
        arrow.SetActive(true);

        cameraMove.StartMoving();
    }

    /*public CameraMove cameraMove;
    cameraMove.StartMoving(); */
}
