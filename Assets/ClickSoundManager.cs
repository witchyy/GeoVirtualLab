using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSoundManager : MonoBehaviour
{
    public static ClickSoundManager Instance;

    public AudioClip clickSound;
    private AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Agar tidak hilang saat pindah scene
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject); // Hapus duplikat jika sudah ada
        }
    }

    public void PlayClick()
    {
        if (clickSound != null)
            audioSource.PlayOneShot(clickSound);
    }

    public void PlayClickAndLoad(string sceneName)
    {
        StartCoroutine(PlayThenLoad(sceneName));
    }

    private System.Collections.IEnumerator PlayThenLoad(string sceneName)
    {
        PlayClick();
        yield return new WaitForSeconds(clickSound.length); // Tunggu suara selesai
        SceneManager.LoadScene(sceneName);
    }
}
