using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyTwo : MonoBehaviour
{
    public float Randomn ;
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Copying",2f,2f);
    }

    // Update is called once per frame
    void Copying()
    {
        Randomn = Random.Range(-4.15f,1.9f);
        Instantiate(Coin, new Vector3(Randomn,1.47f,19f),Quaternion.identity);
    }
}
