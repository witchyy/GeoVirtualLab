using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SwingingTextWithShadow : MonoBehaviour
{
    [Header("Shadow Settings")]
    public Color shadowColor = new Color(0, 0, 0, 0.5f);
    public Vector2 shadowOffset = new Vector2(2f, -2f);
    public bool useGraphicAlpha = true;

    [Header("Swing Settings")]
    public float swingAmplitude = 5f;     // Jarak goyangan (dalam satuan lokal)
    public float swingSpeed = 2f;         // Kecepatan goyangan

    private Vector3 originalPosition;

    void Awake()
    {
        // Tambah shadow jika belum ada
        Shadow shadow = GetComponent<Shadow>();
        if (shadow == null)
            shadow = gameObject.AddComponent<Shadow>();

        shadow.effectColor = shadowColor;
        shadow.effectDistance = shadowOffset;
        shadow.useGraphicAlpha = useGraphicAlpha;

        // Simpan posisi awal teks
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        // Hitung posisi goyang kiri-kanan (X) dan maju-mundur (Z)
        float offsetX = Mathf.Sin(Time.time * swingSpeed) * swingAmplitude;
        float offsetZ = Mathf.Cos(Time.time * swingSpeed * 0.5f) * (swingAmplitude * 0.25f); // gerakan halus ke depan/belakang

        // Update posisi lokal teks
        transform.localPosition = originalPosition + new Vector3(offsetX, 0f, offsetZ);
    }
}
