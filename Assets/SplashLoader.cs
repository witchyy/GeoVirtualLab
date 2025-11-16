using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashLoader : MonoBehaviour
{
    public Slider loadingBar;
    public string sceneTujuan = "MainMenu";
    public float waktuMinimum = 2f; // waktu minimum splash screen tampil

    void Start()
    {
        StartCoroutine(LoadAsyncScene());
    }

    IEnumerator LoadAsyncScene()
    {
        float timer = 0f;
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneTujuan);
        op.allowSceneActivation = false;

        while (op.progress < 0.9f)
        {
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(op.progress / 0.9f);
            loadingBar.value = Mathf.Lerp(loadingBar.value, progress, Time.deltaTime * 3f);
            yield return null;
        }

        // Progress sudah 0.9, tinggal tunggu minimum waktu tampil
        while (timer < waktuMinimum)
        {
            timer += Time.deltaTime;
            loadingBar.value = Mathf.Lerp(loadingBar.value, 1f, Time.deltaTime * 2f);
            yield return null;
        }

        // Bar penuh dan waktu cukup → aktifkan scene
        loadingBar.value = 1f;
        yield return new WaitForSeconds(0.3f); // transisi halus
        op.allowSceneActivation = true;
    }
}
