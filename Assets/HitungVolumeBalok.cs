using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <- wajib saat pakai TextMeshPro

public class HitungVolumeBalok : MonoBehaviour
{
    public TMP_InputField inputPanjang;
    public TMP_InputField inputLebar;
    public TMP_InputField inputTinggi;

    public TMP_Text hasilText;     // Output hasil volume
    public TMP_Text rumusText;     // Output rumus volume

    public void HitungVolume()
    {
        float panjang, lebar, tinggi;

        // Validasi input
        if (float.TryParse(inputPanjang.text, out panjang) &&
            float.TryParse(inputLebar.text, out lebar) &&
            float.TryParse(inputTinggi.text, out tinggi))
        {
            float volume = panjang * lebar * tinggi;

            hasilText.text = " " + volume.ToString("0.##") + " cm³";
            rumusText.text = panjang + " × " + lebar + " × " + tinggi;
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
