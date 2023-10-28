using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Timer timer;
    public float score;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Started()
    {
        timer.StartTime();
    }

    public void Die()
    {
       ;
        Restart();
    }
}
