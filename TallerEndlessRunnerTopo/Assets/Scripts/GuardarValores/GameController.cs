using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController current;
    public float MaxScore;
    //Tienda
    public int insectos = 0;
    public float pointsPerSecond = 5;
    public int Vida = 1;
    //Valores Vision
    public int Ejex = 5;
    public int Ejey = 8;

    //NivelesTienda
    public int NivelMultiplicador = 0;
    public int NivelVIda = 0;
    public int NivelVision = 0;
    

    // Start is called before the first frame update
    private void Awake()
    {
        if(current == null)
        {
            current = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
