using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PanelOnTracking : MonoBehaviour
{
    public GameObject panel;
    public GameObject buttonOpen;
    public GameObject buttonClose;
    public GameObject panelSifat;
public GameObject panelRumus;
    public GameObject panelIsiAwal;

    void Start()
    {
        // Saat awal scene dijalankan, sembunyikan semuanya
        panel.SetActive(false);
        buttonOpen.SetActive(false);
        buttonClose.SetActive(false);
    }

    // Fungsi ini dipanggil dari event Vuforia saat marker terdeteksi
    public void OnTrackingFound()
    {
        panel.SetActive(true);
        buttonOpen.SetActive(false);
        buttonClose.SetActive(true);
    }

    public void OnTrackingLost()
    {
        panel.SetActive(false);
        buttonOpen.SetActive(false);
        buttonClose.SetActive(false);
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
        buttonOpen.SetActive(false);
        buttonClose.SetActive(true);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        panelSifat.SetActive(false);
        panelRumus.SetActive(false);      // ← penting!
        buttonOpen.SetActive(true);
        buttonClose.SetActive(false);
    }
public void KembaliKeIsiUtama()
{
    panelIsiAwal.SetActive(true);
    panelSifat.SetActive(false);
    panelRumus.SetActive(false);
}
    
}
