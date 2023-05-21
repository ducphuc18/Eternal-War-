using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemycontroller : MonoBehaviour
{

    public turret[] turrets;
    public turretmovement aimturret;//

    private void Awake()
    {
        
        if (aimturret == null)
        {
            aimturret = GetComponentInChildren<turretmovement>();
        }
        if (turrets == null || turrets.Length == 0)
        {
            turrets = GetComponentsInChildren<turret>();
        }

    }
    public void handleshoot()
    {
        foreach (var turret in turrets)
        {
            turret.shoot();
        }

    }
    public void handleturrermovement(Vector2 pointerposition)
    {
        aimturret.aim(pointerposition);

    }
}
