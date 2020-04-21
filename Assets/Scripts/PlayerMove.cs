using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horazontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horazontal, 0, vertical);
        movement = transform.TransformDirection(movement);
        gameObject.transform.position += movement * Time.deltaTime * speed;
    }
}
