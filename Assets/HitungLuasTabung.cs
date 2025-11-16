using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitungLuasTabung : MonoBehaviour
{
    public TMP_InputField inputJariJari;    // r
    public TMP_InputField inputTinggi;      // t

    public TMP_Text hasilText;              // Output hasil luas permukaan
    public TMP_Text rumusText;              // Output rumus

    public void HitungLuas()
    {
        float r, t;

        if (float.TryParse(inputJariJari.text, out r) &&
            float.TryParse(inputTinggi.text, out t))
        {
            float luas = 2 * Mathf.PI * r * (r + t);

            hasilText.text = luas.ToString("0.##") + " cm²";
            rumusText.text = "2x3.14 × " + r + " × (" + r + " + " + t + ")";
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
