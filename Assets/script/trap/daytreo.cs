using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daytreo : MonoBehaviour
{
    public float speed = 1f;
    public float amplitude = 1f;
    public float offset = 0f;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float y = Mathf.Sin(Time.time * speed + offset) * amplitude;
        transform.position = startPos + new Vector3(0f, y, 0f);
    }
}
