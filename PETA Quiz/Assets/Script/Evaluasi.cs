using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Evaluasi : MonoBehaviour
{
    public Text benarText,
        salahText;


    // Start is called before the first frame update
    void Start()
    {
        int benar = PlayerPrefs.GetInt("benar1");
        Debug.Log("Jumlah benar : " + benar);

        int benar1 = PlayerPrefs.GetInt("benar1");
        int benar2 = PlayerPrefs.GetInt("benar2");
        int benar3 = PlayerPrefs.GetInt("benar3");
        int benar4 = PlayerPrefs.GetInt("benar4");

        int salah1 = PlayerPrefs.GetInt("salah1");
        int salah2 = PlayerPrefs.GetInt("salah2");
        int salah3 = PlayerPrefs.GetInt("salah3");
        int salah4 = PlayerPrefs.GetInt("salah4");

        int totalBenar = benar1 + benar2 + benar3 + benar4;
        int totalSalah = salah1 + salah2 + salah3 + salah4;

        benarText.text = "Total Benar : " + totalBenar;
        salahText.text = "Total Salah : " + totalSalah;
    }
}
