using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AddShadowEffect : MonoBehaviour
{
    void Start()
    {
        // Cek apakah sudah punya komponen Shadow
        if (GetComponent<Shadow>() == null)
        {
            Shadow shadow = gameObject.AddComponent<Shadow>();
            shadow.effectColor = new Color(0, 0, 0, 0.5f); // hitam transparan
            shadow.effectDistance = new Vector2(2f, -2f);   // arah bayangan
            
        }
    }
}