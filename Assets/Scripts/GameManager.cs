using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject AI;
    public int waveCount = 5;
    public float waveWait = 15;
    public int zombieCount = 25;
    public int wv1Spawn = 5;
    public int spawnUp = 5;
    private bool waveEnd = true;
    public Transform[] spawnPoint;

    private void Update()
    {
        if (waveEnd == true)
        {
            waveEnd = false;
            aiSpawn();
        }
    }

    void aiSpawn()
    {
        Instantiate(AI, spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity);
    }
}
