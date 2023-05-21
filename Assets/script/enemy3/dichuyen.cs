using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class dichuyen : MonoBehaviour
{
    [SerializeField] private Transform[] cacdiem;
    [SerializeField] private float speed;
    int index = 0;
    [SerializeField] private int size;
    
    
 

    private void Start()
    {
        transform.position = cacdiem[index].transform.position; 
       
    }
    private void Update()
    {
        move();
    }

    private void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, cacdiem[index].transform.position, speed*Time.deltaTime);
        if(transform.position == cacdiem[index].transform.position)
        {
            index++;
        } 
        if(index == cacdiem.Length)
        {
            index = 0;
        }    
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(cacdiem[index].position, size);

    }
}
