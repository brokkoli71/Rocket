using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float forceBoost = 1f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(transform.up * forceBoost);
        }
        float forwardInput = Input.GetAxis("Vertical");
    }
}
