using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(movimento * velocidade, 0f);
    }
}