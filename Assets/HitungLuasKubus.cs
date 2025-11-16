using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <- WAJIB saat pakai TextMeshPro

public class HitungLuasKubus : MonoBehaviour
{
    public TMP_InputField inputSisi;   // Input sisi
    public TMP_Text hasilText;         // Output hasil akhir
    public TMP_Text rumusText;         // Output rumus: L = 6 × s²

    public void HitungLuas()
    {
        float sisi;

        // Validasi input
        if (float.TryParse(inputSisi.text, out sisi))
        {
            float luas = 6 * sisi * sisi;

            // Tampilkan rumus dan hasil
           hasilText.text = " " + luas.ToString("0.##") + " cm²";
           rumusText.text = "6 × " + sisi + "²";

        }
        else
        {
            hasilText.text = "masukkan angka!";
            rumusText.text = "";
        }
    }
}
