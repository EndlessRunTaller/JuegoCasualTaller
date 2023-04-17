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
        if(GameController.current.insectos >= 50 && GameController.current.NivelMultiplicador == 0)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 50;
        }
        else if(GameController.current.insectos >= 100 && GameController.current.NivelMultiplicador == 1)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 100;
        }
        else if(GameController.current.insectos >= 200 && GameController.current.NivelMultiplicador == 2)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 200;
        }
        else if(GameController.current.insectos >= 200 && GameController.current.NivelMultiplicador == 3)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 400;
        }
        else if (GameController.current.insectos >= 200 && GameController.current.NivelMultiplicador == 4)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 800;
        }
        else if (GameController.current.insectos >= 200 && GameController.current.NivelMultiplicador == 5)
        {
            GameController.current.NivelMultiplicador = GameController.current.NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 1600;
        }
        else
        {

        }
    }
    public void BotonVida()
    {
        if (GameController.current.insectos >= 500 && GameController.current.NivelVIda == 0)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 200;
        }
        else if(GameController.current.insectos >= 500 && GameController.current.NivelVIda == 1)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 500;
        }
        else if (GameController.current.insectos >= 1000 && GameController.current.NivelVIda == 2)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 1000;
        }
        else if (GameController.current.insectos >= 2000 && GameController.current.NivelVIda == 3)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 2000;
        }
        else if (GameController.current.insectos >= 3000 && GameController.current.NivelVIda == 4)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 3000;
        }
        else if (GameController.current.insectos >= 5000 && GameController.current.NivelVIda == 5)
        {
            GameController.current.NivelVIda = GameController.current.NivelVIda + 1;
            GameController.current.insectos = GameController.current.insectos - 200;
        }
        else
        {

        }
    }
    public void BotonVision()
    {
        if(GameController.current.insectos >= 100 && GameController.current.NivelVision == 0)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 100;
        }
        else if(GameController.current.insectos >= 200 && GameController.current.NivelVision == 1)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 200;
        }
        else if (GameController.current.insectos >= 500 && GameController.current.NivelVision == 2)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 500;
        }
        else if (GameController.current.insectos >= 1000 && GameController.current.NivelVision == 3)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 1000;
        }
        else if (GameController.current.insectos >= 1500 && GameController.current.NivelVision == 4)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 1500;
        }
        else if (GameController.current.insectos >= 2000 && GameController.current.NivelVision == 5)
        {
            GameController.current.NivelVision = GameController.current.NivelVision + 1;
            GameController.current.insectos = GameController.current.insectos - 2000;
        }
        else
        {

        }
    }
    public void DarMultiplicador()
    {
        if (GameController.current.NivelMultiplicador == 0)
        {
            GameController.current.pointsPerSecond = 10;
            precioMultiplicador = 50;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
        else if (GameController.current.NivelMultiplicador == 1)
        {
            GameController.current.pointsPerSecond = 15;
            precioMultiplicador = 100;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
        else if(GameController.current.NivelMultiplicador == 2)
        {
            GameController.current.pointsPerSecond = 20;
            precioMultiplicador = 200;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
        else if(GameController.current.NivelMultiplicador == 3)
        {
            GameController.current.pointsPerSecond = 25;
            precioMultiplicador = 400;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
        else if (GameController.current.NivelMultiplicador == 4)
        {
            GameController.current.pointsPerSecond = 30;
            precioMultiplicador = 800;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
        else if (GameController.current.NivelMultiplicador == 5)
        {
            GameController.current.pointsPerSecond = 35;
            precioMultiplicador = 1600;
            PrecioMultiplicador.text = precioMultiplicador.ToString();
        }
    }

    public void DarVida()
    {
        if(GameController.current.NivelVIda == 0)
        {
            GameController.current.Vida = 1;
            precioVida = 500;
            PrecioVida.text = precioVida.ToString();
        }
        else if(GameController.current.NivelVIda == 1)
        {
            GameController.current.Vida = 2;
            precioVida = 1000;
            PrecioVida.text = precioVida.ToString();
        }
        else if (GameController.current.NivelVIda == 2)
        {
            GameController.current.Vida = 3;
            precioVida = 2000;
            PrecioVida.text = precioVida.ToString();
        }
        else if (GameController.current.NivelVIda == 3)
        {
            GameController.current.Vida = 4;
            precioVida = 3000;
            PrecioVida.text = precioVida.ToString();
        }
        else if (GameController.current.NivelVIda == 4)
        {
            GameController.current.Vida = 5;
            precioVida = 4000;
            PrecioVida.text = precioVida.ToString();
        }
        else if (GameController.current.NivelVIda == 5)
        {
            precioVida = 5000;
            PrecioVida.text = precioVida.ToString();
            GameController.current.Vida = 6;
        }
    }

    public void DarVision()
    {
        if(GameController.current.NivelVision == 0)
        {
            GameController.current.Ejex = 5;
            GameController.current.Ejey = 8;
            precioVision = 100;
            PrecioVision.text = precioVision.ToString();
        }
        else if(GameController.current.NivelVision == 1)
        {
            GameController.current.Ejex = 6;
            GameController.current.Ejey = 8;
            precioVision = 200;
            PrecioVision.text = precioVision.ToString();
        }
        else if (GameController.current.NivelVision == 2)
        {
            GameController.current.Ejex = 6;
            GameController.current.Ejey = 8;
            precioVision = 500;
            PrecioVision.text = precioVision.ToString();
        }
        else if (GameController.current.NivelVision == 3)
        {
            GameController.current.Ejex = 7;
            GameController.current.Ejey = 9;
            precioVision = 1000;
            PrecioVision.text = precioVision.ToString();
        }
        else if (GameController.current.NivelVision == 4)
        {
            GameController.current.Ejex = 8;
            GameController.current.Ejey = 10;
            precioVision = 1500;
            PrecioVision.text = precioVision.ToString();
        }
        else if(GameController.current.NivelVision == 5)
        {
            GameController.current.Ejex = 9;
            GameController.current.Ejey = 11;
            precioVision = 2000;
            PrecioVision.text = precioVision.ToString();
        }
    }
}
