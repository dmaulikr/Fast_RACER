using UnityEngine;
using System.Collections;

public class araçlar : MonoBehaviour
{

    public Transform beyazarac;
    public Transform sariarac;
    public Transform yesilarac;
    public Transform maviarac;
    int rastgele;
    int rastkonum;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            rastgele = Random.Range(0, 16);
            rastkonum = Random.Range(-3, 6);
            if (rastgele == 0)
            {
                Instantiate(beyazarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 1)
            {
                Instantiate(sariarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 2)
            {
                Instantiate(beyazarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 3)
            {
                Instantiate(sariarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 4)
            {
                Instantiate(beyazarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 5)
            {
                Instantiate(sariarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 6)
            {
                Instantiate(beyazarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 7)
            {
                Instantiate(sariarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 8)
            {
                Instantiate(yesilarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 9)
            {
                Instantiate(maviarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 10)
            {
                Instantiate(yesilarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 11)
            {
                Instantiate(maviarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 12)
            {
                Instantiate(yesilarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 13)
            {
                Instantiate(maviarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 14)
            {
                Instantiate(yesilarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
            }
            if (rastgele == 15)
            {
                Instantiate(maviarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
            }
        }
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void Rastgele()
    {
        rastgele = Random.Range(0, 16);
        rastkonum = Random.Range(-3, 6);

        if (rastgele == 0)
        {
            Instantiate(beyazarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 1)
        {
            Instantiate(sariarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 2)
        {
            Instantiate(beyazarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 3)
        {
            Instantiate(sariarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 4)
        {
            Instantiate(beyazarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 5)
        {
            Instantiate(sariarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 6)
        {
            Instantiate(beyazarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 7)
        {
            Instantiate(sariarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 8)
        {
            Instantiate(yesilarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 9)
        {
            Instantiate(maviarac, new Vector3(0.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 10)
        {
            Instantiate(yesilarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 11)
        {
            Instantiate(maviarac, new Vector3(1.5F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 12)
        {
            Instantiate(yesilarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 13)
        {
            Instantiate(maviarac, new Vector3(-0.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 14)
        {
            Instantiate(yesilarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
        }
        if (rastgele == 15)
        {
            Instantiate(maviarac, new Vector3(-1.6F, rastkonum, 0), Quaternion.identity);
        }
    }
}
