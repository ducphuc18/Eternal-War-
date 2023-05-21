using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroydisdable : MonoBehaviour
{
    public bool selfdestructionenabled { get; set; } = false;

    private void OnDisable() // vo hieu hoa
    {
        if (selfdestructionenabled)
        {
            Destroy(gameObject);
        }
    }
}
