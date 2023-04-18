using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnInsecto spawnInsecto;
    public GameObject[] Obstaculo;
    public ScoreManager scoreManager;

    private float timeBtwSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private int PosisionY;

    private void Update()
    {
        if(scoreManager.scoreCount < 190)
        {
            if (timeBtwSpawn <= 0)
            {
                startTimeSpawn = 2;
                int numeroX1 = GenerarNumeroAleatorioX();
                int numeroY1 = GenerarNumeroAleatorioYNivel1();
                if(numeroX1 == spawnInsecto.GenerarNumeroAleatorioX())
                {
                    numeroX1 = numeroX1 + 5;
                }

                Instantiate(Obstaculo[0], transform.position + new Vector3(numeroX1, numeroY1, 0), transform.rotation);
                spawnInsecto.SpawnNivel1();
                timeBtwSpawn = startTimeSpawn;
                if (startTimeSpawn > minTime)
                {
                    startTimeSpawn -= decreaseTime;
                }
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;

            }
        }
        else if(scoreManager.scoreCount > 200 && scoreManager.scoreCount < 500)
        {
            if (timeBtwSpawn <= 0)
            {
                startTimeSpawn = 1.5f;
                int numeroX1 = GenerarNumeroAleatorioX();
                int numeroY1 = GenerarNumeroAleatorioYNivel2();
                if (numeroX1 == spawnInsecto.GenerarNumeroAleatorioX())
                {
                    numeroX1 = numeroX1 + 5;
                }

                Instantiate(Obstaculo[1], transform.position + new Vector3(numeroX1, numeroY1, 0), transform.rotation);
                spawnInsecto.SpawnNivel2();
                timeBtwSpawn = startTimeSpawn;
                if (startTimeSpawn > minTime)
                {
                    startTimeSpawn -= decreaseTime;
                }
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;

            }
        }
        
    }

    //Piedra Random

    public int GenerarNumeroAleatorioX()
    {
        int[] valores = new int[] { 10, 11, 12, 13, 14, 15 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
    public int GenerarNumeroAleatorioYNivel1()
    {
        int[] valores = new int[] { 3, 0, -3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
    public int GenerarNumeroAleatorioYNivel2()
    {
        int[] valores = new int[] { -6, 0, -3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }


}

