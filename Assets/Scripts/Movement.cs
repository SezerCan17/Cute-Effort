using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    public Rigidbody2D rb2D;
    bool rlook;
    public Renderer renderer;
    private CapsuleCollider2D CapsuleCollider2d;
    public AudioSource audioSource;
    public AudioSource audioSource2;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
        renderer = GetComponent<Renderer>();
        CapsuleCollider2d = GetComponent<CapsuleCollider2D>();
        rlook = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(hori * speed, rb2D.velocity.y);
        rb2D.velocity = movement;

        if(hori > 0 && !rlook || hori < 0 && rlook)
        {
            rlook = !rlook;
            Vector3 yon = transform.localScale;
            yon.x *= -1;
            transform.localScale = yon;
        }

        if(Input.GetKeyDown("w"))
        {
            rb2D.gravityScale *= -1;
            Vector3 currentScale = transform.localScale;
            currentScale.y *= -1;
            transform.localScale = currentScale;
            audioSource.Play();
            
            
        }
      
    }
    
       private IEnumerator SlowDownCoroutine()
        {
            Debug.Log("girdi");
            yield return new WaitForSeconds(2.0f);
            speed = 26;
            Debug.Log("speed=26");

        }
    
    
    public void SlowDown()
    {
        speed = 5;
        Debug.Log("speed=5");
        StartCoroutine(SlowDownCoroutine());
    }
    public void Freeze()
    {
        speed = 0;
        Debug.Log("speed=0");
        StartCoroutine(SlowDownCoroutine());
    }

    public void Speed()
    {
        speed = 40;
        Debug.Log("speed=40");
        StartCoroutine(SlowDownCoroutine());

    }

   
   



    
}
