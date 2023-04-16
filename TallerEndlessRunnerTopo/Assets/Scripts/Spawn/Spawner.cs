using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;
    public SpawnInsecto spawnInsecto;

    private float timeBtwSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePattern.Length);
            Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeSpawn;
            if(startTimeSpawn > minTime)
            {
                startTimeSpawn -= decreaseTime;
                spawnInsecto.Spawn();
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
            
        }
    }
}
