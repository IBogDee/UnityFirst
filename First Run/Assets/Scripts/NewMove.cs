using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NewMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    


    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a Forward Force (x , y , z )
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }

           if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }


    }
}