using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public float movementspeed;
    public Transform groundcheck;
    public float groundcheckradius = 0.1f;
    public LayerMask groundmask;

    private void Update()
    {
        transform.Translate(Time.deltaTime * movementspeed * transform.right);
        if (!Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, groundmask))
        {
            flip();
        }
    }
    // Start is called before the first frame update
    private void flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        movementspeed *= -1;
    }
}
