using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panel1;
    public GameManager gameManager1;
    public Timer timer;

    public void StartButton()
    {
        panel1.SetActive(false);
        gameManager1.Started();
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("çýkýss");
    }
}
