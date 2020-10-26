using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Ball_roll : MonoBehaviour
{
    //Variables we need
    public float timer = 5;
    //Direction in the horizontal axis
    float directionX;
    //Direction in the depth axis
    float directionZ;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //timer = UnityEngine.Random.Range(1, 10);
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(1f, 0f, 1f));
        //Start movement speed 
        directionX = (float)UnityEngine.Random.Range(0.1f, 0.9f);
        directionZ = (float)UnityEngine.Random.Range(0.1f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        //Checker to see if addforce works as intended
        //rb.AddForce(new Vector3(directionX, 0f, directionZ));
        //Debug log to check if things are working
        //UnityEngine.Debug.Log(directionX + "" + directionZ);
        if(timer > 0)
        {   
            if (timer % 2 == 0)
            {
                rb.AddForce(new Vector3(directionX, 0f, directionZ));
            } else
            {
                rb.AddForce(new Vector3(-directionX, 0f, -directionZ));
            }
            
            timer -= Time.deltaTime;
        } else
        {
            directionX = (float)UnityEngine.Random.Range(0.1f, 0.9f);
            directionZ = (float)UnityEngine.Random.Range(0.1f, 0.9f);
            timer = 5;
        }
    }
}
