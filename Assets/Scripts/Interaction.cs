using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameManager gameManager;
    public Movement movement;
    public IsitActive isitactive;
    public HealthController healthController;
   


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            healthController.TakeDamage();
            movement.audioSource2.Play();
            Debug.Log("Water");
            
        }

        if (other.gameObject.CompareTag("Diken"))
        {
            healthController.TakeDamage();
            movement.audioSource2.Play();
            Debug.Log("Diken");
           
        }

        if(other.gameObject.CompareTag("SlowDown"))
        {
            movement.SlowDown();
            isitactive.SlowDown();
            Debug.Log("SlowDown");
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Freeze"))
        {
            movement.Freeze();
            isitactive.Freeze();
            Debug.Log("Freeze");
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Speed"))
        {
            movement.Speed();
            isitactive.Speed();
            Debug.Log("Freeze");
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.CompareTag("Health"))
        {
            healthController.GainHeart();
            isitactive.Health();
            Debug.Log("Health");
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("sýnýr"))
        {
            gameManager.Die();
        }
        if (other.gameObject.CompareTag("finish"))
        {
            gameManager.Die();
        }

    }

    
}
