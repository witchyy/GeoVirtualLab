using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitungVolumeBola : MonoBehaviour
{
    public TMP_InputField inputJariJari;    // r
    public TMP_Text hasilText;              // Output hasil volume
    public TMP_Text rumusText;              // Output rumus

    public void HitungVolume()
    {
        float r;

        if (float.TryParse(inputJariJari.text, out r))
        {
            float volume = (4f / 3f) * Mathf.PI * r * r * r;

            hasilText.text = volume.ToString("0.##") + " cm³";
            rumusText.text = "4/3 x 3.14 × " + r + "³";
        }
        else
        {
            hasilText.text = "Masukkan angka!";
            rumusText.text = "";
        }
    }
}
