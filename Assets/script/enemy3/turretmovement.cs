using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretmovement : MonoBehaviour
{
    public float turretRotationSpeed = 150;
    
   
    public void aim(Vector2 inputpointerposition)
    {
        var turretdiection = (Vector3)inputpointerposition - transform.position;//vitrixoayden
        var desireangle = Mathf.Atan2(turretdiection.y, turretdiection.x) * Mathf.Rad2Deg;
        var rotationstep = turretRotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, desireangle), rotationstep);
    }
}
