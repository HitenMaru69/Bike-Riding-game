using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdestroy : MonoBehaviour
{
    public GameObject pannal;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            pannal.SetActive(true);
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            
            Destroy(player);
            pannal.SetActive(true);
        }
    }
}
