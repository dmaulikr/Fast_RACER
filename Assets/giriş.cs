using UnityEngine;
using System.Collections;

public class giriş : MonoBehaviour
{

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
    }
    public void Oyna()
    {
        Application.LoadLevel("araba");
    }
    public void Cik()
    {
        Application.Quit();
    }
}
