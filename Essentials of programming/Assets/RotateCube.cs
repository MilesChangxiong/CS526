using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{

    void Start()
    {

    }

    
    void Update()
    {
        transform.Rotate(Vector3.up, 10 * Time.deltaTime);
    }
}
