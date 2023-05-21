using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congtac2 : MonoBehaviour
{
    [SerializeField] private Animator amin;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            amin.SetTrigger("open");
            flatformbaythang2.instance.kichhoat = true;


        }
    }
}
