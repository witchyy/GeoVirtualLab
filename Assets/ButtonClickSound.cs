using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickSound : MonoBehaviour
{
    public AudioSource audioSource;   // Drag AudioSource dari GameObject ke sini
    public AudioClip clickSound;      // Drag file click.wav ke sini

    // Fungsi ini akan dipanggil dari tombol
    public void PlayClick()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
        else
        {
            Debug.LogWarning("AudioSource atau ClickSound belum diisi!");
        }
    }
}

