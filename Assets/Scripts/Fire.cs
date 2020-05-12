using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float damageRadius;
    public float damageFrequency;
    public int damageControl;


    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, damageRadius);
        if (colliders.Length > 0)
        {
            foreach(Collider col in colliders)
            {
                if (col.GetComponent<Health>())
                {
                    col.GetComponent<Health>().damageCount
                }
            }
        }
    }
}
