using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class Move : MonoBehaviour
{

    //movement speed in units per second
    public float movementSpeed = 5f;
    public float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    Quaternion currentRotation;
    float yrot;
    bool rotOn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        yrot = Input.GetAxis("Horizontal");
        currentEulerAngles += new Vector3(0, yrot, 0) * Time.deltaTime * rotationSpeed;

        currentRotation.eulerAngles = currentEulerAngles;
        transform.rotation = currentRotation;

        //update the position
        if(Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if(Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
    }
}
