using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GantiBentukBalok : MonoBehaviour
{
    public GameObject balokKarakter;
    public GameObject balokRusuk;

    public void TampilkanRusuk()
    {
        balokKarakter.SetActive(false);
        balokRusuk.SetActive(true);
    }

    public void KembaliKeKarakter()
    {
        balokKarakter.SetActive(true);
        balokRusuk.SetActive(false);
    }
}
