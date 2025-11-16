using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransisiKeMenu : MonoBehaviour
{
    public RectTransform panelInfo;
    public float posisiSembunyiY = -800f;
    public float durasi = 0.5f;
    public string namaSceneMenu = "MainMenu";  // ganti sesuai scene kamu

    public void KembaliKeMenuDenganTransisi()
    {
        // Turunkan panel terlebih dahulu
        LeanTween.moveY(panelInfo, posisiSembunyiY, durasi)
            .setEaseInBack()
            .setOnComplete(() =>
            {
                SceneManager.LoadScene(namaSceneMenu);
            });
    }
}
