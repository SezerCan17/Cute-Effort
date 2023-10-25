using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int speed;
    public Rigidbody2D rb2D;
    bool rlook;
    Vector3 currentPos;
    Vector3 currentScale;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
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
            
        }
        else if(Input.GetKeyDown("s"))
        {
            rb2D.gravityScale *= -1;
            Vector3 currentScale = transform.localScale;
            currentScale.y *= -1;
            transform.localScale = currentScale;
        }
    }
}
