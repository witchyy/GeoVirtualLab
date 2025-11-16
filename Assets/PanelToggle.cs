using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelToggle : MonoBehaviour
{
    public GameObject panel;         // Panel penjelasan kubus
    public GameObject buttonOpen;    // Tombol ❯
    public GameObject buttonClose;   // Tombol ❮

    void Start()
    {
        // Saat mulai, panel aktif, tombol ❮ aktif, tombol ❯ tidak aktif
        panel.SetActive(true);
        buttonClose.SetActive(true);
        buttonOpen.SetActive(false);
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
        buttonClose.SetActive(true);
        buttonOpen.SetActive(false);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        buttonClose.SetActive(false);
        buttonOpen.SetActive(true);
    }
}
