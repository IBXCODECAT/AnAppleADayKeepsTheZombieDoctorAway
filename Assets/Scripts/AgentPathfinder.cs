using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentPathfinder : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform player;

    void Update()
    {
       if (player)
        agent.destination = player.position;
    }
    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }
}
