using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GantiBentukBola : MonoBehaviour
{
    public GameObject bolaBiasa;
    public GameObject bolaRusuk;

    public void TampilkanRusukBola()
    {
        bolaBiasa.SetActive(false);
        bolaRusuk.SetActive(true);
    }

    public void KembaliBentukBola()
    {
        bolaBiasa.SetActive(true);
        bolaRusuk.SetActive(false);
    }
}
