using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text yildizpuani;
    public static int yildizpuani_int = 0;

    private void Update()
    {
        yildizpuani.text = yildizpuani_int.ToString(); // Skor değerini ekrandaki metin olarak günceller.
    }
}
