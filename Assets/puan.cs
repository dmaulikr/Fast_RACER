using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class puan : MonoBehaviour
{

    public int puanlama = 0;
    public int çarpma = 0;
    public void puanarttir()
    {
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.1F)
        {
            puanlama = puanlama + 10;
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.1F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.2F)
        {
            puanlama = puanlama + 20;
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.2F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.3F)
        {
            puanlama = puanlama + 30;
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.3F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.4F)
        {
            puanlama = puanlama + 40;
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.4F)
        {
            puanlama = puanlama + 50;
        }
        Destroy(GameObject.Find("arkaplan (1)"));
    }

    void Update()
    {
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = puanlama.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.LoadLevel("Giris");
        }
        if (çarpma == 1)
        {
            if (Input.touchCount == 1)
            {
                Application.LoadLevel("araba");
            }
        }
    }
}
