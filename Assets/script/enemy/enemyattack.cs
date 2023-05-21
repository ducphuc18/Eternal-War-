using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class enemyattack : MonoBehaviour
{
  
    [SerializeField] private float range;
    [SerializeField] private float colliderdistance;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D BoxCollider;
    [SerializeField] private LayerMask playerlayer;
    public Transform vitriattack;
    public float attackrange = 0.5f;
    public LayerMask layer1;
   
    public float attackrate = 2f;
    float nextattacktime = 0f;

    //[SerializeField] private AudioClip attacksound;
   
    private Animator amin;
    private playerheart playerheart;
  


    private void Awake()
    {
        amin = GetComponent<Animator>();
        playerheart = GetComponent<playerheart>();

    }

    private void Update()
    {
       
        if (playerinsight())
        {
            if (Time.time >= nextattacktime)
            {
                attack1();
                nextattacktime = Time.time + 1f / attackrate;


            }
            
        }


    }
    private bool playerinsight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(BoxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderdistance,
            new Vector3(BoxCollider.bounds.size.x * range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z),
            0, Vector2.left, 0, playerlayer);

        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(BoxCollider.bounds.center + transform.right * range * transform.localScale.x * colliderdistance, new Vector3(BoxCollider.bounds.size.x * range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z));
    }
   
    void attack1()
    {
        amin.SetTrigger("attack"); // attack la ten string trong animator
        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(vitriattack.position, attackrange, layer1);
        foreach (Collider2D boss in hitenemy) // vong lap
        {
            //Debug.Log("1 don" + boss.name);
            boss.GetComponent<playerheart>().takedamage(damage);
            
        }

    }
    void OnDrawGizmosSelected()
    {
        if (vitriattack == null)
            return;
        Gizmos.DrawWireSphere(vitriattack.position, attackrange);
    }
}
