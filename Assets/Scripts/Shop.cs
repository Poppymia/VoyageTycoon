using UnityEngine;

public class Shop : MonoBehaviour
{
    public int cost = 100;

    public void BuyUpgrade()
    {
        if (GameManager.instance.coins >= cost)
        {
            GameManager.instance.coins -= cost;
            Debug.Log("Ship repaired!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
}
