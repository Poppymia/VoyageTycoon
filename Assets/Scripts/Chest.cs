using UnityEngine;

public class Chest : MonoBehaviour
{
    public int coinAmount = 50;
    private bool opened = false; 

    /*void Start() {}
    void Update() {}*/

    void OnMouseDown()
    {
        if (!opened)
        {
            GameManager.instance.AddCoins(coinAmount);
            opened = true;
            Debug.Log("Chest opened");
        }
    }
}
