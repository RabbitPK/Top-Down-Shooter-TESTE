using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("ScoreText não foi atribuído no Inspector! Certifique-se de arrastar o objeto de texto.");
        }
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("ScoreText ainda está NULL!");
        }
    }
}
