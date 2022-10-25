using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbMove : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 InputKey;
    float Myfloat;

    void Update()
    {
        ////////////Move With WASD
        InputKey = new Vector3(Input.GetAxis("Horizontal") , 0 , Input.GetAxis("Vertical"));
    }

    void FixedUpdate() 
    {
        /////////// AddForce
        rb.AddForce(InputKey * 50);


        /////////// Velocity
        rb.Velocity = InputKey * 10;


        /////////// MovePosition
        rb.MovePosition((Vector3) transform.position + InputKey * 10 * Time.deltaTime);




        float Angle = Mathf.Atan2(InputKey.x , InputKey.z) * Mathf.Rad2Deg; //=========================================== LookAt
        float Smooth = Mathf.SmoothDampAngle(transform.eulerAngles.y , Angle , ref Myfloat , 0.1f); //=================== Smooth Rotation
        transform.rotation = Quaternion.Euler(0,Smooth,0); //============================================================ Change Angle

    }



}

//BudGames :)
