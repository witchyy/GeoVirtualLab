using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCanvas : MonoBehaviour
{
    public Transform canvas;

    void Update()
    {
        transform.LookAt(canvas);
    }
}
