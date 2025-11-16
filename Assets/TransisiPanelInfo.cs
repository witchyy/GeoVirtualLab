using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransisiPanelInfo : MonoBehaviour
{
    [Header("Panel yang Akan Ditransisikan")]
    public RectTransform panelInfo;

    [Header("Posisi Y untuk Tersembunyi dan Tampil")]
    public float posisiSembunyiY = -800f;
    public float posisiTampilY = 0f;

    [Header("Durasi Animasi (detik)")]
    public float durasi = 0.5f;

    private bool isVisible = false;

    void Start()
    {
        // Panel langsung diset ke posisi tersembunyi saat start
        if (panelInfo != null)
        {
            panelInfo.anchoredPosition = new Vector2(panelInfo.anchoredPosition.x, posisiSembunyiY);
        }
        else
        {
            Debug.LogWarning("PanelInfo belum diisi!");
        }
    }

    public void TogglePanelInfo()
    {
        if (panelInfo == null) return;

        float targetY = isVisible ? posisiSembunyiY : posisiTampilY;

        // Gunakan LeanTween untuk animasi posisi Y
        LeanTween.moveY(panelInfo, targetY, durasi).setEaseOutExpo();

        isVisible = !isVisible;
    }
}
