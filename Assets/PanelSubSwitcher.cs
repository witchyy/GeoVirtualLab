using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSubSwitcher : MonoBehaviour
{
    public GameObject panelSifat;
    public GameObject panelRumus;

    public void ShowSifat()
    {
        panelSifat.SetActive(true);
        panelRumus.SetActive(false);
    }

    public void ShowRumus()
    {
        panelSifat.SetActive(false);
        panelRumus.SetActive(true);
    }
    void Start()
{
    panelSifat.SetActive(false);
    panelRumus.SetActive(false);
}

}

