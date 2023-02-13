using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float move = .5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-move, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(move, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, move);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -move);
        }

    }
}
