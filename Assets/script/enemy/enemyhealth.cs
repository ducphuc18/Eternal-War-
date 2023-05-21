using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
   
    public Animator Animator;
    public int maxhealth = 3;
     int currenthealth;

    void Start()
    {
        currenthealth = maxhealth;

    }

    public void takedamage(int damage)
    {
       
        currenthealth -= damage;
        Animator.SetTrigger("hurt");
        if (currenthealth <= 0)
        {
            die();
        }
    }

    void die()
    {
        //Animator.SetTrigger("die");
       
        this.gameObject.SetActive(false);



    }
}
