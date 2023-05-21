using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gai : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            
            collision.gameObject.GetComponent<playerheart>().takedamage(1);
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            
            collision.gameObject.GetComponent<playerheart>().takedamage(1);
        }
    }
}
