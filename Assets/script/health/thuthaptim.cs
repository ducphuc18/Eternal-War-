using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thuthaptim : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            collision.gameObject.GetComponent<playerheart>().addhealth(4);
            gameObject.SetActive(false);
          
        }    
    }
}
