using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khoidongchidan : MonoBehaviour
{
    public GameObject gbjchidan;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            gbjchidan.SetActive(true);
            gameObject.SetActive(false);
        }    
    }
}
