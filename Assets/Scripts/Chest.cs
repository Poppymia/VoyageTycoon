using UnityEngine;
using TMPro;
using System.Collections;

public class Chest : MonoBehaviour
{
    public int coinAmount = 50;
    public TextMeshProUGUI popupText;
    public Sprite openSprite;
    private bool opened = false;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        if (!opened)
        {
            GameManager.instance.AddCoins(coinAmount);
            opened = true;
            sr.sprite = openSprite;
            StartCoroutine(ShowPopup());
        }
    }

    IEnumerator ShowPopup()
    {
        popupText.gameObject.SetActive(true);
        popupText.text = "+" + coinAmount;
        float duration = 1.5f;
        float elapsed = 0f;
        Vector3 startPos = transform.position + Vector3.up * 0.5f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            popupText.transform.position = startPos + Vector3.up * elapsed;
            float alpha = 1f - (elapsed / duration);
            popupText.color = new Color(1f, 0.8f, 0f, alpha);
            yield return null;
        }
        popupText.gameObject.SetActive(false);
    }
}