using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class dunglen2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameObject;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = GameObject.transform;
           
           
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;

        }
    }

}
