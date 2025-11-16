
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitungLuasBola : MonoBehaviour
{
    public TMP_InputField inputJariJari;    // r
    public TMP_Text hasilText;              // Output hasil luas permukaan
    public TMP_Text rumusText;              // Output rumus

    public void HitungLuas()
    {
        float r;

        if (float.TryParse(inputJariJari.text, out r))
        {
            float luas = 4 * Mathf.PI * r * r;

            hasilText.text = luas.ToString("0.##") + " cm²";
            rumusText.text = "4 x 3.14 × " + r + "²";
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
