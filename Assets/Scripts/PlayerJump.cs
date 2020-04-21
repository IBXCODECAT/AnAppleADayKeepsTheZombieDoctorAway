using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private bool isJumping;

    public Rigidbody rb;
    public float jumpForce;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
    }
}
