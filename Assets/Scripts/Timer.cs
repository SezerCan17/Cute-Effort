using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private float gameTime = 0f; // Zamanlayýcý deðiþkeni
    public TextMeshProUGUI timerText;
    

    void Start()
    {
        StartCoroutine(StartTimer());
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(gameTime / 60);
        int seconds = Mathf.FloorToInt(gameTime % 60);

        // TMP ile zamaný göster
        timerText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
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
