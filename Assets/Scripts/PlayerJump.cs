using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private bool isJumping;

    public Rigidbody rb;
    public float jumpForce;

    public float clamp;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if (isJumping == false)
        {
            transform.position = new Vector3(transform.position.x, clamp, transform.position.z);
        }
        else
        {
            rb.AddForce(Vector3.up * Time.deltaTime * jumpForce);
        }
    }
}
