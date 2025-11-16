using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VolumeKubus : MonoBehaviour
{
    public TMP_InputField inputSisi;
    public TMP_Text rumusText;
    public TMP_Text hasilText;

    public void HitungVolume()
    {
        if (inputSisi == null || rumusText == null || hasilText == null)
        {
            Debug.LogWarning("Ada komponen yang belum diisi di Inspector!");
            return;
        }

        // Ambil nilai sisi dari input
        if (float.TryParse(inputSisi.text, out float sisi))
        {
            float volume = sisi * sisi * sisi;

            // Tampilkan rumus
            rumusText.text = $"{sisi} × {sisi} × {sisi}";

            // Tampilkan hasil
            hasilText.text = $" {volume.ToString("0.##")} cm³";
        }
        else
        {
            rumusText.text = "s × s × s";
            hasilText.text = "Masukkan angka yang valid!";
        }
    }
}
