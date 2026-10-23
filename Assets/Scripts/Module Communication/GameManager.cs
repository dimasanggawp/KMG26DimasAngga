using UnityEngine;
using System;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public event Action OnScoreChanged;
    public int score;
    public int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        StartCoroutine(TimerCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            AddScore(1);
        }

        if(Input.GetMouseButtonDown(1))
        {
            SubstractScore(1);
        }
    }

    void AddScore(int value)
    {
        score += value;
        //scoreUI.UpdateScoreText(score); //Diganti pake event ya om
        OnScoreChanged?.Invoke();
        Debug.Log("Score : " + score);
    }

    void SubstractScore(int value)
    {
        score -= value;
        //scoreUI.UpdateScoreText(score); //Diganti pake event ya om
        OnScoreChanged?.Invoke();
        Debug.Log("Score : " + score);
    }

    IEnumerator TimerCoroutine()
    {
        while(timer < 10)
        {
            Debug.Log("Timer : " + timer);
            yield return new WaitForSeconds(5f);
            timer++;
        }
    }
}
