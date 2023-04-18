using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCalaveras : MonoBehaviour
{
    public GameObject huesos,calavera,arbusto;

    private float timeBtwSpawn;
    public float startTimeSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private int PosisionY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            if (HuesoOCalavera() == 1)
            {
                Instantiate(huesos, transform.position + new Vector3(0, PosicionY(), 0), transform.rotation);
            }
            else if (HuesoOCalavera() == 2)
            {
                Instantiate(calavera, transform.position + new Vector3(0, PosicionY(), 0), transform.rotation);
            }
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
        if (timeBtwSpawn <= 0)
        {
            Instantiate(arbusto, transform.position + new Vector3(15, 3.1f, 0), transform.rotation);
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

    float PosicionY()
    {
        float[] possibleValues = { -0.8f,-3.5f,-5.1f,-2.5f,-2f,-3f,-3.5f };
        float randomNumber = possibleValues[new System.Random().Next(possibleValues.Length)];
        return randomNumber;
    }
    public int HuesoOCalavera()
    {
        int[] valores = new int[] { 1,2 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }

}
