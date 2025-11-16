using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClickAndChangeScene : MonoBehaviour
{
    public AudioClip clickSound;
    public string sceneNameToLoad;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnButtonClick()
    {
        StartCoroutine(PlaySoundAndChangeScene());
    }

    IEnumerator PlaySoundAndChangeScene()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
            yield return new WaitForSeconds(clickSound.length); // Tunggu sampai suara selesai
        }

        SceneManager.LoadScene(sceneNameToLoad);
    }
}

