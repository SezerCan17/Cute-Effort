using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float gameTime = 0f; // Zamanlayýcý deðiþkeni
    public TextMeshProUGUI timerText;
    private bool TimerStart;
    

    void Start()
    {
        TimerStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerStart)
        {
            gameTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(gameTime / 60);
            int seconds = Mathf.FloorToInt(gameTime % 60);

            // TMP ile zamaný göster
            timerText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
    }

    public void StartTime()
    {
        StartCoroutine(StartTimer());
        TimerStart = true;
    }

    private IEnumerator StartTimer()
    {
        float duration = 60f; // Örnek olarak 60 saniye

        while (gameTime < duration)
        {
            yield return null;
        }

    }
    /*public void PauseTimer()
    {
        isTimerRunning = !isTimerRunning;
        if (isTimerRunning)
        {
            StartCoroutine(StartTimer());
        }
        else
        {
            StopCoroutine(StartTimer());
        }
    }

    public void ResetTimer()
    {
        gameTime = 0f;
    }*/
}
