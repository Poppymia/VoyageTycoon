using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coins = 0;
    public TextMeshProUGUI coinText;

    void Awake()
    {
        instance = this;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        coinText.text = "Coins: " + coins;
    }

    /*void Start() { }
    void Update() { }*/
}
