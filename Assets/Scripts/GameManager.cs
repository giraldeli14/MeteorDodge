using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton;
    public TextMeshProUGUI scoreText;

    private int score = 0;

    public void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.SetActive(true);

        Time.timeScale = 0f;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}