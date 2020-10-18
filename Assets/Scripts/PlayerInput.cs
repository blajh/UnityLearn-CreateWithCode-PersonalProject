using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        // Check for Axis input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Apply input to "Movement", actually Root rotation
        //transform.Ro += horizontalInput;
        //transform.rotation.y += verticalInput;


    }
}
