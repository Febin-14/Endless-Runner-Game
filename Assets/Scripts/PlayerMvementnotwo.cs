using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerMvementnotwo : MonoBehaviour
{
    public AudioSource Ads;

    public AudioClip Coin;
    public AudioClip Coin2XClip;
    public AudioClip InvinclbleClip;
    public Animator Anie;
    public int points;
    public float speed = 5f;
    public float jumpspeed ;
    public Rigidbody rb;
    public bool isOnGround = true;
    private int JumpCount = 0;
    private int maxJumps = 2;
    public TextMeshProUGUI texte;
     float Scoree;
     public bool  PowerUpBOOL = false;
     public bool Coin2xBool = false;
    public bool speedBool = false;
     public float Timer; 
     public GameObject powertext;
     public bool Coin2x;
    public float coinMultiplier = 1f; // Default multiplier
    public float speedMultiplier = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        texte.text = "Score = 0";
    }

    // Update is called once per frame      
    void Update()
    {
        
        powertext.GetComponent<TMP_Text>().text = "Power Up: " + Mathf.Round(Timer);
        if(Timer >   0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            Timer = 0;
            PowerUpBOOL = false;
            Coin2xBool = false;
            coinMultiplier = 1f;
            speedMultiplier = 1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x < -3.035f)
            {
                transform.position = new Vector3(-3.035f, transform.position.y, transform.position.z);
            }
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.    D)||Input.GetKey(KeyCode. RightArrow))
        {
             if(transform.position.x > 3.053f)
             {
            transform.position =new Vector3(3.053f,transform.position.y,transform.position.z);
             }
        }
        else
        {
            transform.Translate(Vector3.left *Time.deltaTime*speed);
        }


        /*  if(Input.GetKey(KeyCode.    W))
          {
              transform.Translate(Vector3.forward*Time.deltaTime*speed);
          }
          if(Input.GetKey(KeyCode.    S))
          {
              transform.Translate(Vector3.back*Time.deltaTime*speed);
          }*/
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        }

        //Anie.SetBool("Jump", !isOnGround);


    }

 
         
         private void OnCollisionEnter (Collision  collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
            Debug.Log("Collided with Enemy" + collision.gameObject.name);
                if(PowerUpBOOL == true)
                {
                    Destroy(collision.gameObject);
                }
                else{
                    Destroy(gameObject);
             
                SceneManager.LoadScene("Retry");
                }
                
            }
            /*if(collision.gameObject.CompareTag("Coin"))
            {
                Destroy(collision.gameObject);
            }*/
             if(collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
                JumpCount = 0;
            }

        }
         public void OnTriggerEnter(Collider collider)
        {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin Hit!");

            Destroy(collider.gameObject);

            Scoree += 1 * coinMultiplier;
            Ads.PlayOneShot(Coin);

            texte.text = "Score = " + Scoree;

            Debug.Log("Current Score = " + Scoree);
        }   
        else if(collider.gameObject.CompareTag("Power"))
            {
                Destroy(collider.gameObject);
                Timer = 10f;
            Ads.PlayOneShot(InvinclbleClip);
                PowerUpBOOL = true;

            }
            else if(collider.gameObject.CompareTag("Coin2X"))
            {

            Coin2xBool = true;
            Ads.PlayOneShot(Coin2XClip);
                Destroy(collider.gameObject);
                Timer = 10f;
                coinMultiplier = 2f;

            }
            
           
            
            //print(points); 
           
        
        }
       

      
       
    
    }
    
    

        

