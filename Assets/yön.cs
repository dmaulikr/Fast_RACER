using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class yön : MonoBehaviour
{

    public float surat;
    float yaz;
    public AudioClip kaza;
    private AudioSource kaynak;
    void Start()
    {
        GameObject.Find("Canvas/Text (2)").GetComponent<Text>().enabled = false;
   
    }
    void Awake()
    {
        kaynak = GetComponent<AudioSource>();
    }
    void Update()
    {
        Application.targetFrameRate = 75;
        if (Input.touchCount == 0 || Input.touchCount == 1)
        {
            transform.Translate(-Input.acceleration.x * surat, 0, 0);
        }
        if (Input.touchCount == 1 && GameObject.Find("puann").GetComponent<puan>().çarpma == 0)
        {
            if (surat > 0.06F)
            {
                surat = surat - 0.025F;
            }
            if (surat > 0.005f && surat <= 0.06F)
            {
                surat = surat - 0.005f;
            }
            GameObject.Find("GameObject").GetComponent<AudioSource>().volume = 0.1f;

        }
        if (Input.touchCount == 0 && GameObject.Find("puann").GetComponent<puan>().çarpma == 0)
        {
            GameObject.Find("GameObject").GetComponent<AudioSource>().volume = 0.3f;
        }
        if (surat < 0.42f && GameObject.Find("puann").GetComponent<puan>().çarpma == 0)
        {
            surat = surat + 0.002f;
        }
        yaz = (surat * 1000) / 2;

        GameObject.Find("Canvas/Text (1)").GetComponent<Text>().text = yaz.ToString("0") + "km/h";
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(surat, 0, 0);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(-surat, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "yesil(Clone)" || collision.gameObject.name == "mavi(Clone)" || collision.gameObject.name == "sari(Clone)" || collision.gameObject.name == "beyaz(Clone)" || collision.gameObject.name == "sağ1" || collision.gameObject.name == "sol1")
        {
            GameObject.Find("Canvas/Text (2)").GetComponent<Text>().text = "SCORE \n" + GameObject.Find("Canvas/Text").GetComponent<Text>().text.ToString() + "\nFor New Game \nPlease Touch Screen ";
            GameObject.Find("Canvas/Text (2)").GetComponent<Text>().enabled = true;
            GameObject.Find("Canvas/Text (1)").GetComponent<Text>().enabled = false;
            GameObject.Find("Canvas/Text").GetComponent<Text>().enabled = false;
            GameObject.Find("puann").GetComponent<puan>().çarpma = 1;
            GameObject.Find("GameObject").GetComponent<AudioSource>().volume = 0;
            kaynak.PlayOneShot(kaza, 0.4F);
            surat = 0;
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "sağ")
        {
            transform.position = new Vector3(1.6F, -13.4F, 0);
        }
        if (collision.gameObject.name == "sol")
        {
            transform.position = new Vector3(-1.6F, -13.4F, 0);
        }
    }
  
}
