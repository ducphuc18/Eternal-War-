using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    public Animator animator;
    public Transform vitriattack;
    public float attackrange = 0.5f;
    public LayerMask layer1;
    public int attackdamage = 40;
    public float attackrate = 2f;
    float nextattacktime = 0f;
  
    // Start is called before the first frame update
    private void Update()
    {
        if (Time.time >= nextattacktime)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                soundmanager.instance.playsound("chem", 1f);
                attack1();
                nextattacktime = Time.time + 0.3f ;
            }
        }


    }
    void attack1()
    {
        animator.SetTrigger("attack"); // attack la ten string trong animator
        Collider2D[] hitenemy = Physics2D.OverlapCircleAll(vitriattack.position, attackrange, layer1);
        foreach (Collider2D boss in hitenemy) // vong lap
        {
            //Debug.Log("1 don" + boss.name);
            boss.GetComponent<enemyhealth>().takedamage(attackdamage);
            
        }

    }
    void OnDrawGizmosSelected()
    {
        if (vitriattack == null)
            return;
        Gizmos.DrawWireSphere(vitriattack.position, attackrange);
    }
}
