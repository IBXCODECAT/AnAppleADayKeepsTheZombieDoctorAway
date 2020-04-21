using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPosition;
    public float fireRate;

    public float force;

    bool shooting;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0) && !shooting)
        {
            shooting = true;
            StartCoroutine(Shooting());

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
