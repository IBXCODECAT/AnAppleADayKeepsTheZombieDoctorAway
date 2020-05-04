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
    private int waveCurrent;
    private int zombieCheck;

    private void Start()
    {
        zombieCheck = wv1Spawn;
    }
    private void Update()
    {
        if (waveEnd == true && waveCurrent<waveCount)
        {
          
            waveEnd = false;
            waveCurrent++;
            if (zombieCheck < zombieCount)
            {
                aiSpawn(); 
                zombieCheck += spawnUp;
            }

           
        }
    }

    void aiSpawn()
    {
        StartCoroutine(wavePause());
     for (int i = 0; i < zombieCheck; i++)
        Instantiate(AI, spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity);
    }
    IEnumerator wavePause() 
    {
        yield return new WaitForSeconds(waveWait);
        waveEnd = true;
    }
}
