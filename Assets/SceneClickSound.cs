using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClickSound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    public static SceneClickSound Instance; // GLOBAL AKSES

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject); // Hapus duplikat kalau ada
        }
    }

    public void PlayClick()
    {
        audioSource.PlayOneShot(clickSound);
    }

    public void PlayClickAndLoad(string sceneName)
    {
        StartCoroutine(PlayAndLoad(sceneName));
    }

    private System.Collections.IEnumerator PlayAndLoad(string sceneName)
    {
        audioSource.PlayOneShot(clickSound);
        yield return new WaitForSeconds(clickSound.length);
        SceneManager.LoadScene(sceneName);
    }
}
