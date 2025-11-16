using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // kalau pakai TextMeshPro

public class JudulBergerak : MonoBehaviour
{
    public float amplitude = 10f;  // tinggi gerakan
    public float frequency = 2f;   // kecepatan

    Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.localPosition = startPos + new Vector3(0, y, 0);
    }
}

