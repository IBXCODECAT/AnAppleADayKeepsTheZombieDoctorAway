using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 500;
    private int currentHealth;
    [Space]
    public float fillSpeed = 3;

    public Image healthBar;

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

    private void Update()
    {
        healthBar.fillAmount = Mathf.MoveTowards(healthBar.fillAmount, (float)currentHealth / maxHealth, fillSpeed * Time.deltaTime);
    }

    public void death()
    {
        Destroy(gameObject);
    }

}
