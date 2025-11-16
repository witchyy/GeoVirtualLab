using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // <- wajib saat pakai TextMeshPro

public class HitungLuasLimas : MonoBehaviour
{
    public TMP_InputField inputPanjangAlas;   // sisi panjang alas
    public TMP_InputField inputLebarAlas;     // sisi lebar alas
    public TMP_InputField inputTinggiSisi;    // tinggi sisi tegak limas (bukan tinggi bangun)

    public TMP_Text hasilText;     // Output hasil luas permukaan
    public TMP_Text rumusText;     // Output rumus

    public void HitungLuas()
    {
        float panjang, lebar, tinggiSisi;

        // Validasi input
        if (float.TryParse(inputPanjangAlas.text, out panjang) &&
            float.TryParse(inputLebarAlas.text, out lebar) &&
            float.TryParse(inputTinggiSisi.text, out tinggiSisi))
        {
            // Luas alas
            float luasAlas = panjang * lebar;

            // Luas selubung (4 segitiga: 2 segitiga dengan alas panjang, 2 dengan alas lebar)
            float luasSelubung = 0.5f * panjang * tinggiSisi * 2 + 0.5f * lebar * tinggiSisi * 2;

            float luasPermukaan = luasAlas + luasSelubung;

            hasilText.text = " " + luasPermukaan.ToString("0.##") + " cm²";
            rumusText.text = "(" + panjang + "×" + lebar + ") + [½×(" + panjang + "+" + lebar + ")×" + tinggiSisi + " × 2 ]";
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
