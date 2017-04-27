using UnityEngine;
using System.Collections;

public class arkakopya : MonoBehaviour
{

    public Transform nesne;
    public void arkaplanuret()
    {
        Instantiate(nesne, new Vector3(0, 2F, 0), Quaternion.identity);
    }
}
