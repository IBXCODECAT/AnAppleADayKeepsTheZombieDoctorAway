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
        gameObject.transform.position += (Vector3.forward * vertical * Time.deltaTime * speed);
        gameObject.transform.position += (Vector3.right * horazontal * Time.deltaTime * speed);
    }
}
