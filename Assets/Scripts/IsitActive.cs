using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsitActive : MonoBehaviour
{
    [SerializeField] 
    private GameObject slowdown;
    public GameObject freeze;
    public GameObject speed;
    public GameObject health;
    public void SlowDown()
    {
        slowdown.SetActive(false);
    }

    public void Freeze()
    {
        freeze.SetActive(false);
    }
    public void Speed()
    {
        speed.SetActive(false);
    }

    public void Health()
    {
        health.SetActive(false);
    }

   
}
