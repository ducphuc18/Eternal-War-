using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacham : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
           //tudongbaythang.instance.kichhoat = true;

        }
    }
}
