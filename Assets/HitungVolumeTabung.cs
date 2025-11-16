
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitungVolumeTabung : MonoBehaviour
{
    public TMP_InputField inputJariJari;    // r
    public TMP_InputField inputTinggi;      // t

    public TMP_Text hasilText;              // Output hasil volume
    public TMP_Text rumusText;              // Output rumus

    public void HitungVolume()
    {
        float r, t;

        if (float.TryParse(inputJariJari.text, out r) &&
            float.TryParse(inputTinggi.text, out t))
        {
            float volume = Mathf.PI * r * r * t;

            hasilText.text = volume.ToString("0.##") + " cm³";
            rumusText.text = "3.14 × " + r + "² × " + t;
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
