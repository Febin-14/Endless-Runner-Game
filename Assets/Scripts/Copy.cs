using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy : MonoBehaviour
{   
    public GameObject[] obstacles;
    public int obs;
    public float RNDMN;
    public GameObject PowerUp;
    public GameObject Coin2X;
    public float nms;
    public float rdmn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Copying",5f,3f);
        InvokeRepeating("Randomizer",8f,8f);
        InvokeRepeating("Randomizer1",8f,8f);
    }

    // Update is called once per frame
    
    public void Copying()
    {
        obs = Random.Range(0,3);
        RNDMN = Random.Range(-2.332f,2.523f);

            Instantiate(obstacles[obs], new Vector3(RNDMN,0.052f,10.54f),Quaternion.identity);

        
    }
    public void Randomizer()
    {
        rdmn = Random.Range(-2.332f,2.523f);

        Instantiate(PowerUp,new Vector3(rdmn,1.14f,10.54f),Quaternion.Euler(0,90,0));
       // Instantiate(Coin2X,new Vector3(rdmn,1.14f,10.54f),Quaternion.Euler(0,90,0));

    
    }
    public void Randomizer1()
    {
        rdmn = Random.Range(-2.332f,2.523f);

        
        Instantiate(Coin2X,new Vector3(rdmn,1.14f,10.54f),Quaternion.Euler(0,90,0));

    
    }

}
