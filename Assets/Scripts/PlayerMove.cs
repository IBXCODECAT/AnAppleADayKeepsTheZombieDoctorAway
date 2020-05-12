using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
    public float speed = 7f;
    public float gravity = 14f;
    public float jumpForce = 10f;
    public LayerMask environment;

    float verticalVelocity;
    CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horazontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horazontal, 0, vertical);
        movement = transform.TransformDirection(movement);
        movement.y = 0;

        if (cc.isGrounded)
        {
            Debug.Log("Is Grounded");
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
                Debug.Log("Jump!");
            }
        }
        else
        {
            Debug.Log("Not grounded!");
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 move = new Vector3(movement.x * speed, verticalVelocity, movement.z * speed);
        cc.Move(move * Time.deltaTime);

        if (transform.position.y < -100)
        {
            SceneManager.LoadScene(0);
        }
    }
}
