using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 500;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void damageCount(int damage)
    {
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0)
        {
            print("You died!");
            death();
        }

    }

    public void death()
    {

    }

}
