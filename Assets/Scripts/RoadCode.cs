using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class RoadCode : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back *Time.deltaTime *speed);
        if(transform.position.z < 14.59f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,46.06f);
        }
    }
}
