using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShakyTextWithShadow : MonoBehaviour
{
    [Header("Shadow Settings")]
    public Color shadowColor = new Color(0, 0, 0, 0.5f);
    public Vector2 shadowOffset = new Vector2(2f, -2f);
    public bool useGraphicAlpha = true;

    [Header("Shake Settings")]
    public float shakeAmount = 2f;   // seberapa jauh goyang
    public float shakeSpeed = 5f;    // seberapa cepat goyang

    private Vector3 originalPosition;

    void Awake()
    {
        // Tambahkan komponen Shadow jika belum ada
        Shadow shadow = GetComponent<Shadow>();
        if (shadow == null)
            shadow = gameObject.AddComponent<Shadow>();

        // Atur properti shadow
        shadow.effectColor = shadowColor;
        shadow.effectDistance = shadowOffset;
        shadow.useGraphicAlpha = useGraphicAlpha;

        // Simpan posisi awal
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        // Goyang-goyang posisi lokal X dan Y
        float offsetX = Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
        float offsetY = Mathf.Cos(Time.time * shakeSpeed) * shakeAmount;
        transform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);
    }
}
