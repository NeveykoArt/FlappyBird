using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score { get; set; }
    public static ScoreManager Instance { get; set; }

    private void Start()
    {
        ScoreManager.Instance = this;
        SetScore(0);
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
    }
}
