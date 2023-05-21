using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class attackplayer : MonoBehaviour
{
    [SerializeField] private int damage;
    private playerheart playerheart;
   
    private void Awake()
    {
        playerheart = GetComponent<playerheart>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            collision.GetComponent<playerheart>().takedamage(damage);
            gameObject.SetActive(false);
            

        }
    }
}
