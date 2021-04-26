using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float forceBoost = 50f;
    public float forceTilt = 2f;
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
            playerRb.AddForce(transform.up * forceBoost);
        }
        //to be changed to tilt object
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(transform.up * forceTilt);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(transform.up * forceTilt);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(transform.up * forceTilt);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(transform.up * forceTilt);
        }
    }
}
