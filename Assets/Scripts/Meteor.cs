using UnityEngine;

public class Meteor : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GAME OVER!");

            GameManager gameManager = FindFirstObjectByType<GameManager>();
            gameManager.GameOver();
        }
    }

    private void Update()
    {
        if (transform.position.y < -5f)
        {
            GameManager gameManager = FindFirstObjectByType<GameManager>();
            gameManager.AddScore();

            Destroy(gameObject);
        }
    }
}