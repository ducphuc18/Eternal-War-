using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIBehaviour : MonoBehaviour 
{

    public abstract void performaction(enemycontroller tank, aidetector detector); 

}
