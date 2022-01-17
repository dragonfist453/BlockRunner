using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float forwardForce = 100;
    public float sidewaysForce = 100;
    public float jumpForce = 100;

    void FixedUpdate()
    {
        rigidBody.AddForce(0,0,forwardForce*Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) {
            rigidBody.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && transform.position.y > 0.95 && transform.position.y < 1.05) {
            rigidBody.AddForce(0,jumpForce*Time.deltaTime,0, ForceMode.VelocityChange);
        }
    }
}
