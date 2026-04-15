using UnityEngine;

public class BeachTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Next scene!");
            // SceneManager.LoadScene("NextScene");
        }
    }
}
