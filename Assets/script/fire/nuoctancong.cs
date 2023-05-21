using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuoctancong : MonoBehaviour
{
    [SerializeField] private int damage;
    private playerheart playerheart;
    private void Awake()
    {
        playerheart = GetComponent<playerheart>();
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            collision.gameObject.GetComponent<playerheart>().takedamage(damage);
            


        }
    }
}
