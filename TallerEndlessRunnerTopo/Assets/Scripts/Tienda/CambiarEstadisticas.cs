using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiarEstadisticas : MonoBehaviour
{
    public TextMeshProUGUI PrecioVida, PrecioMultiplicador, PrecioVision;
    public int precioVida, precioMultiplicador, precioVision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DarMultiplicador();
        DarVida();
        DarVision();
    }

    public void BotonMultiplicador()
    {
        if(GameController.current.insectos >= 50)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 50;
        }
    }
    public void BotonVida()
    {
        if (GameController.current.insectos >= 200)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 200;
        }
    }
    public void BotonVision()
    {
        if(GameController.current.insectos >= 50)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 50;
        }
    }
    public void DarMultiplicador()
    {
        if (GameController.current.NivelMultiplicador == 0)
        {
            GameController.current.pointsPerSecond = 10;
        }
        else if (GameController.current.NivelMultiplicador == 1)
        {
            GameController.current.pointsPerSecond = 15;
        }
        else if(GameController.current.NivelMultiplicador == 2)
        {
            GameController.current.pointsPerSecond = 20;
        }
        else if(GameController.current.NivelMultiplicador == 3)
        {
            GameController.current.pointsPerSecond = 25;
        }
        else if (GameController.current.NivelMultiplicador == 4)
        {
            GameController.current.pointsPerSecond = 30;
        }
        else if (GameController.current.NivelMultiplicador == 5)
        {
            GameController.current.pointsPerSecond = 35;
        }
    }

    public void DarVida()
    {
        if(GameController.current.NivelVIda == 0)
        {
            GameController.current.Vida = 1;
        }
        else if(GameController.current.NivelVIda == 1)
        {
            GameController.current.Vida = 2;
        }
        else if (GameController.current.NivelVIda == 2)
        {
            GameController.current.Vida = 3;
        }
        else if (GameController.current.NivelVIda == 3)
        {
            GameController.current.Vida = 4;
        }
        else if (GameController.current.NivelVIda == 4)
        {
            GameController.current.Vida = 5;
        }
        else if (GameController.current.NivelVIda == 5)
        {
            GameController.current.Vida = 6;
        }
    }

    public void DarVision()
    {
        if(GameController.current.NivelVision == 0)
        {
            GameController.current.Ejex = 5;
            GameController.current.Ejey = 8;
        }
        else if(GameController.current.NivelVision == 1)
        {
            GameController.current.Ejex = 6;
            GameController.current.Ejey = 8;
        }
        else if (GameController.current.NivelVision == 2)
        {
            GameController.current.Ejex = 6;
            GameController.current.Ejey = 8;
        }
        else if (GameController.current.NivelVision == 3)
        {
            GameController.current.Ejex = 7;
            GameController.current.Ejey = 9;
        }
        else if (GameController.current.NivelVision == 4)
        {
            GameController.current.Ejex = 8;
            GameController.current.Ejey = 10;
        }
        else if(GameController.current.NivelVision == 5)
        {
            GameController.current.Ejex = 9;
            GameController.current.Ejey = 11;
        }
    }
}
