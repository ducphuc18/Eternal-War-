using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xoay : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(0,0,360*rotationSpeed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            player.GetComponent<playerheart>().takedamage(1);
        }
    }
}
