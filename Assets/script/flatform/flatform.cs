using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flatform : MonoBehaviour
{
    public dataflatform dataflatform;
    
    private bool moveleft;
    private float leftedge;
    private float rightedge;

    private void Awake()
    {
        leftedge = transform.position.x - dataflatform.movementdistance;//transform.position.x vi tri hien tai cua trap
        rightedge = transform.position.x + dataflatform.movementdistance;
       
    }
    private void Update()
    {
        if (moveleft)
        {
            if (transform.position.x > leftedge)
            {
                transform.position = new Vector3(transform.position.x - dataflatform.movementdistance * dataflatform.speed * Time.deltaTime, transform.position.y, transform.position.z);

            }
            else
            {
                moveleft = false;
            }
        }
        else
        {
            if (transform.position.x < rightedge)
            {
                transform.position = new Vector3(transform.position.x + dataflatform.movementdistance * dataflatform.speed * Time.deltaTime, transform.position.y, transform.position.z);

            }
            else
            {
                moveleft = true;
            }
        }

    }
}
