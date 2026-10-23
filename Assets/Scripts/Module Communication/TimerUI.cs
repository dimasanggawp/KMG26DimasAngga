using UnityEngine;
using UnityEngine.UI;
public class TimerUI : MonoBehaviour
{
    public GameManager GameManager;
    public Image FillBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FillBar.fillAmount = 0;
        GameManager.OnTimerChanged += OnTimerChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTimerChanged(int timer, int maxTime)
    {
        float normalizedTime = (float)timer / maxTime;
        FillBar.fillAmount = normalizedTime;
    }
}
