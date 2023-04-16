using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnInsecto spawnInsecto;
    public GameObject Obstaculo;

    private float timeBtwSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private int PosisionY;

    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            PosisionY = GenerarNumeroAleatorioY();
            Instantiate(Obstaculo, transform.position + new Vector3(0, PosisionY, 0), transform.rotation);
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

    public int GenerarNumeroAleatorioY()
    {
        int[] valores = new int[] { 3, 0, -3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
}

