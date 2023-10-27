using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Water"))
        {

            Debug.Log("Water");
        }

        if (other.gameObject.CompareTag("Diken"))
        {

            Debug.Log("Diken");
        }
    }

    
}
