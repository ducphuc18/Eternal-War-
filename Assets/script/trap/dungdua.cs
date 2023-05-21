using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungdua : MonoBehaviour
{
    public Transform anchor; // Truy?n vào Transform c?a Anchor (tâm xoay)
    public Transform pointB; // Truy?n vào Transform c?a ?i?m B
    public float speed;
    private void Update()
    {
        // Tính toán góc quay c?a Anchor
        float angle = Time.time * speed;
        Quaternion rotation = Quaternion.Euler(0f, 0f, angle);

        // C?p nh?t v? trí và xoay c?a Anchor
        anchor.rotation = rotation;
        anchor.position = pointB.position;
    }
}
