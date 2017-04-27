using UnityEngine;
using System.Collections;

public class araçhiz : MonoBehaviour
{
   
    void Start()
    {
        transform.Rotate(0, 0, 180);
    }
    void Update()
    {
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.1F)
        {
            transform.Translate(0, GameObject.Find("pitstop_car_1").GetComponent<yön>().surat - 0.3F, 0);
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.1F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.2F)
        {
            transform.Translate(0, GameObject.Find("pitstop_car_1").GetComponent<yön>().surat - 0.1F, 0);
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.2F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.3F)
        {
            transform.Translate(0, GameObject.Find("pitstop_car_1").GetComponent<yön>().surat - 0.1F, 0);
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.3F && GameObject.Find("pitstop_car_1").GetComponent<yön>().surat < 0.4F)
        {
            transform.Translate(0, GameObject.Find("pitstop_car_1").GetComponent<yön>().surat - 0.15F, 0);
        }
        if (GameObject.Find("pitstop_car_1").GetComponent<yön>().surat >= 0.4F)
        {
            transform.Translate(0, GameObject.Find("pitstop_car_1").GetComponent<yön>().surat - 0.20F, 0);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "araccarp")
        {
            GameObject.Find("puann").GetComponent<puan>().puanarttir();
        }
        GameObject.Find("deneme").GetComponent<araçlar>().Rastgele();
        Destroy(gameObject);
    }

}
