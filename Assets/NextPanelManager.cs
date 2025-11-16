using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPanelManager : MonoBehaviour
{
    public GameObject[] panels; // Panel info atau UI
    public GameObject[] objek3Ds; // Objek 3D untuk ditampilkan
    private int index = 0;

    public void Next()
    {
        // Matikan panel & objek lama
        panels[index].SetActive(false);
        objek3Ds[index].SetActive(false);

        // Tambahkan index
        index++;
        if (index >= panels.Length) index = 0; // Loop balik ke awal kalau sudah habis

        // Aktifkan panel & objek baru
        panels[index].SetActive(true);
        objek3Ds[index].SetActive(true);
    }
}
