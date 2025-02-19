using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // punteggio iniziale
    public TMP_Text scoreText; // riferimento al testo UI 

    // aggiunge i punti
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    // aggoirna il testo UI
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "score: " + score.ToString();
        }
    }
}
