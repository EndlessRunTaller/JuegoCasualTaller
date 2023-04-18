using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInsecto : MonoBehaviour
{
    public GameObject[] insecto;
    public void SpawnNivel1()
    {
        Instantiate(insecto[0], transform.position + new Vector3(GenerarNumeroAleatorioX(), GenerarNumeroAleatorioYNivel1(), 0), transform.rotation);
    }

    public void SpawnNivel2()
    {
        Instantiate(insecto[1], transform.position + new Vector3(GenerarNumeroAleatorioX(), GenerarNumeroAleatorioYNivel2(), 0), transform.rotation);
    }
    public void SpawnNivel3()
    {
        Instantiate(insecto[2], transform.position + new Vector3(GenerarNumeroAleatorioX(), GenerarNumeroAleatorioYNivel3(), 0), transform.rotation);
    }


    //Insecto Random

    public int GenerarNumeroAleatorioX()
    {
        int[] valores = new int[] { 10, 11, 12, 13, 14, 15 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
    public int GenerarNumeroAleatorioYNivel1()
    {
        int[] valores = new int[] { 3,0,-3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }


    public int GenerarNumeroAleatorioYNivel2()
    {
        int[] valores = new int[] { -6, 0, -3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }
    public int GenerarNumeroAleatorioYNivel3()
    {
        int[] valores = new int[] { -6, -9, -3 };
        int indiceAleatorio = UnityEngine.Random.Range(0, valores.Length);
        return valores[indiceAleatorio];
    }

}
