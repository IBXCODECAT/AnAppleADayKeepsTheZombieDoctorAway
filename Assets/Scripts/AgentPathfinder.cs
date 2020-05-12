using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentPathfinder : MonoBehaviour
{
    private Health healthScript;
    public NavMeshAgent agent;
    public Transform player;

    public int damageValue;
    public float cooldownTimer;

    bool cooldownActive;

    void Update()
    {
        if (player)
        {
            agent.destination = player.position;
        }

        if (player.transform && agent.transform && Vector3.Distance(agent.transform.position, player.position) <= 2)
        {
            Debug.Log("Player in atack range!");
            if (!cooldownActive)
            {
                Debug.Log("Damaging Player");
                cooldownActive = true;
                healthScript.damageCount(damageValue, Vector3.zero);
                StartCoroutine(damageCooldDown());
            }
        }
    }
    private void Start()
    {
        player = GameObject.Find("Player").transform;
        healthScript = player.GetComponent<Health>();
    }

    IEnumerator damageCooldDown()
    {
        yield return new WaitForSeconds(cooldownTimer);
        cooldownActive = false;
        Debug.Log("Cooldown Complete!");
    }
}
