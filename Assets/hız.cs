using UnityEngine;
using System.Collections;

public class hız : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.gameObject.name == "çarp")
        {
            GameObject.Find("GameObject").GetComponent<arkakopya>().arkaplanuret();
        }
        if (trig.gameObject.name == "kaybol")
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {

        transform.Translate(0, -GameObject.Find("pitstop_car_1").GetComponent<yön>().surat, 0);
    }
}
