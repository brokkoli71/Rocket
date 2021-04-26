﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float forceBoost = 50f;
    public float forceTurn = 2f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(transform.up * forceBoost + Input.GetAxis("Vertical") * Input.GetAxis("Horizontal") * forceTurn);
        }
    }
}
