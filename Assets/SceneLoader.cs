using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Fungsi untuk pindah ke scene berdasarkan nama
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Fungsi untuk keluar dari aplikasi (jika di-build)
    public void KeluarAplikasi()
    {
        Application.Quit();
        Debug.Log("Aplikasi keluar (jika dalam build)");
    }
}
