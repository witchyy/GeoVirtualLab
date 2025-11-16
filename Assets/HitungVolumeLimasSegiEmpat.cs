using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitungVolumeLimasSegiEmpat : MonoBehaviour
{
    public TMP_InputField inputSisiAlas;   // s
    public TMP_InputField inputTinggiLimas; // t (tinggi dari alas ke puncak)

    public TMP_Text hasilText;     // Output volume
    public TMP_Text rumusText;     // Tampilkan rumus hitung

    public void HitungVolume()
    {
        float sisi, tinggi;

        if (float.TryParse(inputSisiAlas.text, out sisi) &&
            float.TryParse(inputTinggiLimas.text, out tinggi))
        {
            float volume = (1f / 3f) * sisi * sisi * tinggi;

            hasilText.text = " " + volume.ToString("0.##") + " cm³";
            rumusText.text = "⅓ × " + sisi + "² × " + tinggi;
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
