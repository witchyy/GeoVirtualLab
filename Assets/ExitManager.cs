using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public void KeluarAplikasi()
    {
            Debug.Log("Aplikasi akan keluar...");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_ANDROID
            Application.Quit();
#elif UNITY_STANDALONE
            Application.Quit();
#endif
    }
}
