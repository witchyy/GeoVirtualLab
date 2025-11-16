using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CustomTextShadow : MonoBehaviour
{
    [Header("Shadow Settings")]
    public Color shadowColor = new Color(0, 0, 0, 0.5f);      // Warna bayangan
    public Vector2 shadowDistance = new Vector2(2f, -2f);     // Arah dan jarak bayangan
    public bool useGraphicAlpha = true;

    void Awake()
    {
        // Tambahkan komponen Shadow jika belum ada
        Shadow shadow = GetComponent<Shadow>();
        if (shadow == null)
            shadow = gameObject.AddComponent<Shadow>();

        // Set properti shadow dari inspector
        shadow.effectColor = shadowColor;
        shadow.effectDistance = shadowDistance;
        shadow.useGraphicAlpha = useGraphicAlpha;
    }
}
