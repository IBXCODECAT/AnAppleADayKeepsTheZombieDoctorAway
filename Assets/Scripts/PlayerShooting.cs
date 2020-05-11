using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPosition;

    public Animator scopeAnimator;

    public float fireRate;

    public float force;

    [HideInInspector]
    public bool shooting;

    private bool inOrOut;

    public PlayerLook lookPlayer;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0) && !shooting)
        {
            shooting = true;
            StartCoroutine(Shooting());
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            scope();
        }
    }

    void scope()
    {
        inOrOut = !inOrOut;
        scopeAnimator.SetBool("Scope Animation", inOrOut);
        if (inOrOut == true)
        {
            lookPlayer.axes = RotationAxes.MouseX;
        }
        else
        {
            lookPlayer.axes = RotationAxes.MouseXAndY;
        }
    }

    IEnumerator Shooting()
    {
        GameObject newProjectile = Instantiate(projectile, spawnPosition.position, spawnPosition.rotation);
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * force);
        yield return new WaitForSeconds(fireRate);
        shooting = false;
    }
}
