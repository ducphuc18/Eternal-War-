using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungdua : MonoBehaviour
{
    public Transform anchor; // Truy?n v�o Transform c?a Anchor (t�m xoay)
    public Transform pointB; // Truy?n v�o Transform c?a ?i?m B
    public float speed;
    private void Update()
    {
        // T�nh to�n g�c quay c?a Anchor
        float angle = Time.time * speed;
        Quaternion rotation = Quaternion.Euler(0f, 0f, angle);

        // C?p nh?t v? tr� v� xoay c?a Anchor
        anchor.rotation = rotation;
        anchor.position = pointB.position;
    }
}
