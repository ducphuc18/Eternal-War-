using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaulenemyai : MonoBehaviour
{
    [SerializeField] private AIBehaviour shootbehaviour;
    [SerializeField] private enemycontroller tank;
    [SerializeField] private aidetector detector;

    private void Awake()
    {
        detector = GetComponentInChildren<aidetector>();
        tank = GetComponentInChildren<enemycontroller>();
    }

    private void Update()
    {
        if (detector.targetvisible)
        {
            shootbehaviour.performaction(tank, detector);//performdetection // ban
        }
       
    }
}
