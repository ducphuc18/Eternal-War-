using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xoaydau : MonoBehaviour
{
    [SerializeField]private GameObject gameobject;
    
    private void Update()
    {
        if(gameobject.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-9,9,9);
        }
        else 
        { 
         transform.localScale = new Vector3(9,9,9);   
        }
    }
}
