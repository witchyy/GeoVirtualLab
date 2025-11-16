using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] allPanels;
    public GameObject[] allObjeks;

    public void SwitchTo(int index)
    {
        for (int i = 0; i < allPanels.Length; i++)
        {
            allPanels[i].SetActive(i == index);
            allObjeks[i].SetActive(i == index);
        }
    }
    public void TestPindahBalok()
{
    allPanels[0].SetActive(false);
    allPanels[1].SetActive(true);
    allObjeks[0].SetActive(false);
    allObjeks[1].SetActive(true);
}
}
