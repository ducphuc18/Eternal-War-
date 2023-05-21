using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISHOOT : AIBehaviour
{
    public float fieldofvisionforshooting = 60;


    public override void performaction(enemycontroller tank, aidetector detector)
    {


        if (TargetInFOV(tank, detector))
        {
            //tank.handlemovebody(Vector2.zero); // ngan di chuyen khi ban
            tank.handleshoot();
        }
        tank.handleturrermovement(detector.Target.position);
    }
    private bool TargetInFOV(enemycontroller tank, aidetector detector)
    {

        var direction = detector.Target.position - tank.aimturret.transform.position;
        if (Vector2.Angle(tank.aimturret.transform.right, direction) < 20) // luc xoay den neu goc xoay con l?i > 30 do thi khong ban
        {

            return true;
        }
        return false;
    }

}
