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
    public bool isPlayer;
    public bool hitEffect = true;

    public GameObject[] hitEffects;

    bool isDead;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void damageCount(int damage, Vector3 position)
    {
        if (isDead) return;
        currentHealth = currentHealth - damage;

        if(!isPlayer && hitEffect)
            Instantiate(hitEffects[Random.Range(0, hitEffects.Length)], position, Quaternion.identity);

        if (currentHealth <= 0)
        {
            print("Player Died!");
            death();
        }

    }

    private void Update()
    {
        healthBar.fillAmount = Mathf.MoveTowards(healthBar.fillAmount, (float)currentHealth / maxHealth, fillSpeed * Time.deltaTime);
    }

    public void death()
    {
        isDead = true;
        if (isPlayer)
        {
            UserInterface.instance.dead();
        }
        else
        {
            GameManager.Instance.EnemyDied();
            Destroy(gameObject);
        }
    }

}
