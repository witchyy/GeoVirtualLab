using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backsounding : MonoBehaviour
{
    public AudioSource audioSource;  // AudioSource untuk backsound
    public AudioClip backsoundClip;  // Musik backsound

    void Start()
    {
        audioSource.clip = backsoundClip;   // Setel clip ke backsound
        audioSource.loop = true;  // Membuat musik diulang
        audioSource.Play();  // Memulai backsound
    }
}
