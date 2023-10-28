using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameManager GameManager;
    public Image[] heartImages; 
    public int maxHealth = 3;   
    private int currentHealth = 3;
    void Start()
    {
            currentHealth = maxHealth;
            UpdateHeartsUI();
  
    }
    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            UpdateHeartsUI();
        }
    }
    public void GainHeart()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth++;
            UpdateHeartsUI();
        }
    }

    private void UpdateHeartsUI()
    {
        for (int i = 0; i < maxHealth; i++)
        {
            if (i < currentHealth)
            {
                heartImages[i].enabled = true;
            }
            else
            {
                heartImages[i].enabled = false;
            }
        }
        if(currentHealth==0)
        {

            GameManager.Die();
        }
    }
    
}
