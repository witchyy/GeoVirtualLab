using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GantiBentukTabung : MonoBehaviour
{
    public GameObject tabungBiasa;
    public GameObject tabungRusuk;

    public void TampilkanRusukTabung()
    {
        tabungBiasa.SetActive(false);
        tabungRusuk.SetActive(true);
    }

    public void KembaliBentukTabung()
    {
        tabungBiasa.SetActive(true);
        tabungRusuk.SetActive(false);
    }
}
