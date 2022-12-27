using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    bool ismove;
    Rigidbody2D rb;
    public float speed = 10f;

    public bool isGround;
    public float rotatespeed;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     ;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        
            ismove = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            ismove = false;
        }
    }

    private void FixedUpdate()
    {
        if (ismove == true)
        {
            if (isGround == true)
            {
                
                rb.AddForce(transform.right * speed, ForceMode2D.Force);

            }
            
            

        }
        else
        {
            rb.AddTorque(-rotatespeed, ForceMode2D.Force);
        }
    }

    private void OnCollisionEnter2D()
    {
        isGround = true;
    }

    private void OnCollisionExit2D()
    {
        isGround = false;
        
    }

    

}
