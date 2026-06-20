using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class DestroyCode : MonoBehaviour
{
    
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back *Time.deltaTime *speed, Space.World);
        if(transform.position.z < -14)
        {
            Destroy(gameObject);
            
        }
        //  if(Input.GetKeyDown(KeyCode.F))
        //      {
        //              ScorePrint();
        //      }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Obstacle hit " + collision.gameObject.name);
    }
    //   public void ScorePrint()
    //     {
    //         Scoree += 5;
    //         texte.text = " Score :" + Scoree;
    //     }


}
