using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInsecto : MonoBehaviour
{
    public GameObject insecto;
    private int Carriles;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Carriles = GenerarNumeroAleatorioY();
    }

    public void Spawn()
    {
        Instantiate(insecto, transform.position + new Vector3(0, Carriles, 0), transform.rotation);
    }

    public int GenerarNumeroAleatorioY()
    {
        int[] valores = new int[] { 3,0,-3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
}
