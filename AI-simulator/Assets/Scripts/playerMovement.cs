///////////////////////////////////////////////
//Name:Breanna Henriquez 
//Date:02/04/2022
//Purpose: To make my own character controller
///////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //private 
    private float speed;
    private float mouseSpeed;
    private Vector2 mouseXY;

    // Start is called before the first frame update
    void Start()
    {
        //set the speed
        speed = 3.0f;
        mouseSpeed = 5f;
        mouseXY = new Vector2(0, 0);

        //lock the cusor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug purposes
        Debug.DrawLine(transform.position, transform.position + transform.forward * 5.0f, Color.red); //foward
        Debug.DrawLine(transform.position, transform.position + transform.right * 5.0f, Color.blue); //right

        //rotation
        mouseXY.x = Input.GetAxis("Mouse X");
        mouseXY.y += Input.GetAxis("Mouse Y");

        float xRotate = mouseXY.y * mouseSpeed;
        xRotate = Mathf.Clamp(-xRotate, -90.0f, 90.0f);

        //rotation
        Camera.main.transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f); 
        transform.Rotate(Vector3.up * mouseXY.x);

        //toggle running 
        if (Input.GetKeyDown(KeyCode.LeftShift)) { speed = 6.0f; }
        if (Input.GetKeyUp(KeyCode.LeftShift)) { speed = 3.0f; }

        if (Input.GetKey(KeyCode.W))
        {
            //move forwards
            transform.position += (transform.forward * speed) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            //move backwards
            transform.position -= (transform.forward * speed) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            //move left
            transform.position -= (transform.right * speed) * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            //move right
            transform.position += (transform.right * speed) * Time.deltaTime;
        }
    }
}
