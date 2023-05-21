using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public static playermovement instance;
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumppower;

    private Animator amin;
    private BoxCollider2D boxcollider;
    private float walljumpcooldown;
    private float horintalinput;
    public bool playermovement1;
   
    //private bool grounded;



    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
        body = GetComponent<Rigidbody2D>();
        amin = GetComponent<Animator>();
        boxcollider = GetComponent<BoxCollider2D>();



    }
   
    private void Update()
    {

        playermoving();
    }

    public void playermoving()
    {
        if(playermovement1)
        {
           
            horintalinput = Input.GetAxis("Horizontal");
           
            body.velocity = new Vector2(horintalinput * speed, body.velocity.y);
           
           
            if (horintalinput > 0.01f)
            {
                
                transform.localScale = new Vector3(9f, 9f, 9f);// viet tat cho vector3(1,1,1)
            }
            else if (horintalinput < -0.01f)
            {
               
                transform.localScale = new Vector3(-9f, 9f, 9f);
            }
            amin.SetBool("run", horintalinput != 0);// setbool(trang thai,dieu kien) neu horintal ko bang 0 thi chay

            if (Input.GetKey(KeyCode.UpArrow))
            {
                amin.SetTrigger("jump");
                transform.Translate(Vector3.up * jumppower * Time.deltaTime);
            }

        }
        else
        {
            playermovement1 = false;
        }    

    }
  
  
}
