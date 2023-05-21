using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    
    public float speed = 10;
    public int damage = 5;
    public float maxdistance = 10;
    private Vector2 startposition;
    private float conquaredistance = 0;
    private Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    public void initialize()
    {
        
        startposition = transform.position;
        rb2d.velocity = -transform.up * speed;
    }
    private void Update()
    {
        conquaredistance = Vector2.Distance(transform.position, startposition);
        if (conquaredistance >= maxdistance)
        {
            Disableobject();
        }

    }
    private void Disableobject()
    {
        rb2d.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }
}
