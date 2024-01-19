using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LossWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public void PlayerLoss()
    {
        int score = ScoreManager.Instance.score;
        scoreText.text = "Score: " + score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (bestScore < score)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", score);
        }
        bestScoreText.text = "Best: " + bestScore.ToString();
    }
}
