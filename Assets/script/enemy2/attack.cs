using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class attack : MonoBehaviour
{
    private Animator amin;
    private playermovement playmovement;
    [SerializeField] private float attackcooldown;
    [SerializeField] private Transform firepoint;
    [SerializeField] private GameObject[] fireballs;
    
    private float cooldowntimer;// = Mathf.Infinity;//vo cuc

    private void Awake()
    {
        amin = GetComponent<Animator>();
        playmovement = GetComponent<playermovement>();
    }
    private void Update()
    {
        cooldowntimer += Time.deltaTime;

        if (cooldowntimer > attackcooldown)//&& playmovement.canattack()
        {
           
            attack1();

        }
        // ko chi thi chi ban dc 1 lan
    }
    private void attack1()
    {
        
       
        cooldowntimer = 0;
        
        fireballs[0].transform.position = firepoint.position;
        fireballs[0].GetComponent<fire>().setdirection(Mathf.Sign(transform.localScale.x));
    }
}
