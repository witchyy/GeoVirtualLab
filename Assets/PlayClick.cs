using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClick : MonoBehaviour
{
    public AudioClip clickSound;         // Masukkan file suara klik di Inspector
    private AudioSource audioSource;     // Akan otomatis diambil dari komponen AudioSource

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
            Debug.Log("Klik tombol - suara dimainkan.");
        }
        else
        {
            Debug.LogWarning("AudioSource atau ClickSound belum diisi!");
        }
    }
}
