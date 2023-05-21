using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flatformbaythang2 : MonoBehaviour
{
    public static flatformbaythang2 instance;
    public float movement;
    public float speed;
    public bool kichhoat;
    private bool moveleft;
    private float leftedge;
    private float rightedge;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        leftedge = transform.position.y - movement;//transform.position.x vi tri hien tai cua trap
        rightedge = transform.position.y + movement;

    }
    public void Update()
    {
        if (kichhoat)
        {
            if (moveleft)
            {
                if (transform.position.y > leftedge)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - movement * speed * Time.deltaTime, transform.position.z);

                }
                else
                {
                    moveleft = false;
                }
            }
            else
            {
                if (transform.position.y < rightedge)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + movement * speed * Time.deltaTime, transform.position.z);

                }
                else
                {
                    moveleft = true;
                }
            }
        }
        else
        {
            kichhoat = false;
        }


    }
}
