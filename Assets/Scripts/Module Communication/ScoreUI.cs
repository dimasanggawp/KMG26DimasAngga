using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class ScoreUI : MonoBehaviour
{
    public GameManager GameManager;
    public TMP_Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.OnScoreChanged += OnScoreChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreText(int score)
    {
        ScoreText.text = "Score : " + score;
    }

    public void OnScoreChanged()
    {
        UpdateScoreText(GameManager.score);
    }
}
