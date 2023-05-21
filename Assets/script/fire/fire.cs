using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;

    private BoxCollider2D boxcollider;
    private Animator amin;
    private float lifetime;
   
    private void Awake()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        amin = GetComponent<Animator>();
    }

    private void Update()
    {
      
        float movementspeed = speed * Time.deltaTime * direction;
        transform.Translate(movementspeed, 0, 0);
        lifetime += Time.deltaTime;
        if (lifetime > 2)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        boxcollider.enabled = true;

    }
    public void setdirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);

        boxcollider.enabled = true;
        float localscalex = transform.localScale.x;
        if (Mathf.Sign(localscalex) != _direction)
        {
            localscalex = -localscalex;
        }
        transform.localScale = new Vector3(localscalex, transform.localScale.y, transform.localScale.z);
    }
}
