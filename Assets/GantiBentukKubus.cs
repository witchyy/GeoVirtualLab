using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GantiBentukKubus : MonoBehaviour
{
    public GameObject kubusBiasa;
    public GameObject kubusRusuk;

    public void TampilkanRusukKubus()
    {
        kubusBiasa.SetActive(false);
        kubusRusuk.SetActive(true);
    }

    public void KembaliBentukKubus()
    {
        kubusBiasa.SetActive(true);
        kubusRusuk.SetActive(false);
    }
}
