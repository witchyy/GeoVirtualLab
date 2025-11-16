using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GantiBentukLimas : MonoBehaviour
{
    public GameObject limasBiasa;
    public GameObject limasRusuk;

    public void TampilkanRusukLimas()
    {
        limasBiasa.SetActive(false);
        limasRusuk.SetActive(true);
    }

    public void KembaliBentukLimas()
    {
        limasBiasa.SetActive(true);
        limasRusuk.SetActive(false);
    }
}
