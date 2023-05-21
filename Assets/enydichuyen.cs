using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enydichuyen : MonoBehaviour
{

    private Vector2 movementvector;
    public Rigidbody2D rb2d;

    public float maxspeed = 10;
    public float rotaspeed = 100;
    public float acceleration = 70;
    public float deacceleration = 50;
    public float currentspeed = 5f;
    public float currentforwardirection = 1;
   
    public void Move(Vector2 movementvector)
    {
        this.movementvector = movementvector;
        calculatespeed(movementvector);
        if (movementvector.y > 0)
        {
            currentforwardirection = 1;
        }
        else if (movementvector.y < 0)
        {
            currentforwardirection = -1;
        }
    }

    private void calculatespeed(Vector2 movementvector)
    {
        if (Mathf.Abs(movementvector.y) > 0)
        {
            currentspeed += acceleration * Time.deltaTime;
        }
        else
        {
            currentspeed -= deacceleration * Time.deltaTime;
        }
        currentspeed = Mathf.Clamp(currentspeed, 0, maxspeed);
    }
    private void FixedUpdate()
    {
        
        rb2d.velocity = (Vector2)transform.up * currentspeed * currentforwardirection * Time.fixedDeltaTime;
       rb2d.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, -movementvector.x * rotaspeed * Time.fixedDeltaTime));
    }
}
