using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <- wajib untuk TextMeshPro

public class HitungLuasBalok : MonoBehaviour
{
    public TMP_InputField inputPanjang;
    public TMP_InputField inputLebar;
    public TMP_InputField inputTinggi;

    public TMP_Text hasilText;         // Output hasil akhir
    public TMP_Text rumusText;         // Output rumus

    public void HitungLuas()
    {
        float panjang, lebar, tinggi;

        // Validasi input
        if (float.TryParse(inputPanjang.text, out panjang) &&
            float.TryParse(inputLebar.text, out lebar) &&
            float.TryParse(inputTinggi.text, out tinggi))
        {
            float luas = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi);

            // Tampilkan hasil
            hasilText.text = " " + luas.ToString("0.##") + " cm²";
            rumusText.text = "2 × (" + panjang + "×" + lebar + " + " + panjang + "×" + tinggi + " + " + lebar + "×" + tinggi + ")";
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
