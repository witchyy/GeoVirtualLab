using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 3f;

    private Vector2 lastPos;
    private bool isDragging = false;

    void Update()
    {
        // ---- Input Mouse (Laptop/Editor) ----
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastPos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0) && isDragging)
        {
            Vector2 delta = (Vector2)Input.mousePosition - lastPos;
            RotateByDelta(delta);
            lastPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // ---- Input Touch (HP) ----
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                lastPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Vector2 delta = touch.position - lastPos;
                RotateByDelta(delta);
                lastPos = touch.position;
            }
        }
    }

    void RotateByDelta(Vector2 delta)
    {
        float rotX = delta.y * rotationSpeed * Time.deltaTime;
        float rotY = -delta.x * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.right, rotX, Space.World);
        transform.Rotate(Vector3.up, rotY, Space.World);
    }
}
