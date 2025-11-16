using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TampilKeterangan : MonoBehaviour
{
    public RectTransform panelWrapper; // Panel + tombol gabung di sini
    private bool isVisible = false;

    public float posisiTersembunyi = -100f; // posisi awal (sembunyi)
    public float posisiTampil = -90f;       // naik sedikit aja (muncul)
    public float durasi = 0.4f;

    public void ToggleKeterangan()
    {
        float targetY = isVisible ? posisiTersembunyi : posisiTampil;

        // Panel dan tombol ikut naik/turun bareng
        LeanTween.moveY(panelWrapper, targetY, durasi).setEaseOutExpo();

        isVisible = !isVisible;
    }
}
