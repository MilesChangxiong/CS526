using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private Rigidbody rb; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        MoveBall(); 
    }

    private void MoveBall()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");   

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        rb.velocity = moveDirection * 5.0f; 
    }
}


