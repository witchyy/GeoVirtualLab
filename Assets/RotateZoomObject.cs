using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotateZoomObject : MonoBehaviour
{
    private Vector3 previousMousePosition;
    public float rotationSpeed = 0.2f;
    public float zoomSpeed = 0.01f;
    public float minScale = 0.2f;
    public float maxScale = 2f;

    public GraphicRaycaster raycaster;
    public EventSystem eventSystem;

    [Header("Drag Panel UI dari Hierarchy ke sini")]
    public RectTransform panelUI;

    void Start()
    {
        if (raycaster == null)
            raycaster = FindObjectOfType<GraphicRaycaster>();
        if (eventSystem == null)
            eventSystem = FindObjectOfType<EventSystem>();
    }

    void Update()
    {
        // Jika menyentuh panel UI, hentikan rotasi dan zoom
        if (IsTouchInPanel())
            return;

#if UNITY_EDITOR
        // Rotasi via mouse
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - previousMousePosition;
            float rotX = delta.y * rotationSpeed;
            float rotY = -delta.x * rotationSpeed;
            transform.Rotate(Camera.main.transform.up, rotY, Space.World);
            transform.Rotate(Camera.main.transform.right, rotX, Space.World);
        }
        previousMousePosition = Input.mousePosition;

        // Zoom via scroll mouse
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            Vector3 newScale = transform.localScale + Vector3.one * scroll * zoomSpeed;
            newScale = Vector3.Max(Vector3.one * minScale, Vector3.Min(Vector3.one * maxScale, newScale));
            transform.localScale = newScale;
        }
#endif

        // Rotasi via satu sentuhan (drag)
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float rotX = touch.deltaPosition.y * rotationSpeed;
                float rotY = -touch.deltaPosition.x * rotationSpeed;
                transform.Rotate(Camera.main.transform.up, rotY, Space.World);
                transform.Rotate(Camera.main.transform.right, rotX, Space.World);
            }
        }

        // Zoom via pinch dua jari
        else if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 prevTouchZero = touchZero.position - touchZero.deltaPosition;
            Vector2 prevTouchOne = touchOne.position - touchOne.deltaPosition;

            float prevDistance = Vector2.Distance(prevTouchZero, prevTouchOne);
            float currDistance = Vector2.Distance(touchZero.position, touchOne.position);

            float delta = currDistance - prevDistance;

            Vector3 newScale = transform.localScale + Vector3.one * delta * zoomSpeed;
            newScale = Vector3.Max(Vector3.one * minScale, Vector3.Min(Vector3.one * maxScale, newScale));
            transform.localScale = newScale;
        }
    }

    private bool IsTouchInPanel()
    {
        if (panelUI == null) return false;

#if UNITY_EDITOR
        return RectTransformUtility.RectangleContainsScreenPoint(panelUI, Input.mousePosition);
#else
        if (Input.touchCount == 0) return false;
        return RectTransformUtility.RectangleContainsScreenPoint(panelUI, Input.GetTouch(0).position);
#endif
    }
}
