using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public LayerMask ground;

    public float jumpForce;

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(new Vector3(player.position.x, player.position.y / 2, player.position.z), 1f);
    }

    private void Update()
    {
        if (Physics.CheckSphere(new Vector3(player.position.x, player.position.y / 2, player.position.z), 1f, ground))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * Time.deltaTime * jumpForce);
            }

            Debug.Log("Player Is Grounded");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.LogWarning("A Gameobject Was Instructed To Jump, But The Gameobject Was Not Grounded!");
            }

            Debug.Log("Player Is Not Grounded");
        }
    }
}
