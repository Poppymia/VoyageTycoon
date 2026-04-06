using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float moveInput;
    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        Debug.Log("Animator found: " + anim);
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        
        if (moveInput != 0)
            anim.Play("Pirat01_Walking");
        else
            anim.Play("Pirat01_Idle");

        if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * moveInput * speed * Time.deltaTime);
    }
}