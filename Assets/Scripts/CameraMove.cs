using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 2f;
    public float moveDuration = 2f;

    private bool move = false;
    private float timer = 0f;

    public void StartMoving()
    {
        move = true;
        timer = 0f;
    }

    void Update()
    {
        if (move)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

            timer += Time.deltaTime;

            if (timer >= moveDuration)
            {
                move = false;
            }
        }
    }
}
