using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraMejoras : MonoBehaviour
{
    public GameObject[] barraMejoraVida;
    public GameObject[] barraMejoraPotenciador;
    public GameObject[] barraMejoraVision;

    public Image Multiplicador;
    public Sprite x2, x3, x4, x5, x6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MejoraVida();
        MejoraMultiplicador();
    }
    public void MejoraVida()
    {
        if (GameController.current.NivelVIda == 0)
        {
            barraMejoraVida[0].SetActive(true);
            barraMejoraVida[1].SetActive(false);
            barraMejoraVida[2].SetActive(false);
            barraMejoraVida[3].SetActive(false);
            barraMejoraVida[4].SetActive(false);
            barraMejoraVida[5].SetActive(false);
        }
        else if (GameController.current.NivelVIda == 1)
        {
            barraMejoraVida[0].SetActive(false);
            barraMejoraVida[1].SetActive(true);
            barraMejoraVida[2].SetActive(false);
            barraMejoraVida[3].SetActive(false);
            barraMejoraVida[4].SetActive(false);
            barraMejoraVida[5].SetActive(false);
        }
        else if (GameController.current.NivelVIda == 2)
        {
            barraMejoraVida[0].SetActive(false);
            barraMejoraVida[1].SetActive(false);
            barraMejoraVida[2].SetActive(true);
            barraMejoraVida[3].SetActive(false);
            barraMejoraVida[4].SetActive(false);
            barraMejoraVida[5].SetActive(false);
        }
        else if (GameController.current.NivelVIda == 3)
        {
            barraMejoraVida[0].SetActive(false);
            barraMejoraVida[1].SetActive(false);
            barraMejoraVida[2].SetActive(false);
            barraMejoraVida[3].SetActive(true);
            barraMejoraVida[4].SetActive(false);
            barraMejoraVida[5].SetActive(false);
        }
        else if (GameController.current.NivelVIda == 4)
        {
            barraMejoraVida[0].SetActive(false);
            barraMejoraVida[1].SetActive(false);
            barraMejoraVida[2].SetActive(false);
            barraMejoraVida[3].SetActive(false);
            barraMejoraVida[4].SetActive(true);
            barraMejoraVida[5].SetActive(false);
        }
        else if (GameController.current.NivelVIda == 5)
        {
            barraMejoraVida[0].SetActive(false);
            barraMejoraVida[1].SetActive(false);
            barraMejoraVida[2].SetActive(false);
            barraMejoraVida[3].SetActive(false);
            barraMejoraVida[4].SetActive(false);
            barraMejoraVida[5].SetActive(true);
        }


    }
    public void MejoraMultiplicador()
    {
        if (GameController.current.NivelMultiplicador == 0)
        {
            barraMejoraPotenciador[0].SetActive(true);
            barraMejoraPotenciador[1].SetActive(false);
            barraMejoraPotenciador[2].SetActive(false);
            barraMejoraPotenciador[3].SetActive(false);
            barraMejoraPotenciador[4].SetActive(false);
            barraMejoraPotenciador[5].SetActive(false);
            Multiplicador.sprite = x2;
        }
        else if(GameController.current.NivelMultiplicador == 1)
        {
            barraMejoraPotenciador[0].SetActive(false);
            barraMejoraPotenciador[1].SetActive(true);
            barraMejoraPotenciador[2].SetActive(false);
            barraMejoraPotenciador[3].SetActive(false);
            barraMejoraPotenciador[4].SetActive(false);
            barraMejoraPotenciador[5].SetActive(false);
            Multiplicador.sprite = x3;
        }
        else if (GameController.current.NivelMultiplicador == 2)
        {
            barraMejoraPotenciador[0].SetActive(false);
            barraMejoraPotenciador[1].SetActive(false);
            barraMejoraPotenciador[2].SetActive(true);
            barraMejoraPotenciador[3].SetActive(false);
            barraMejoraPotenciador[4].SetActive(false);
            barraMejoraPotenciador[5].SetActive(false);
            Multiplicador.sprite = x4;
        }
        else if (GameController.current.NivelMultiplicador == 3)
        {
            barraMejoraPotenciador[0].SetActive(false);
            barraMejoraPotenciador[1].SetActive(false);
            barraMejoraPotenciador[2].SetActive(false);
            barraMejoraPotenciador[3].SetActive(true);
            barraMejoraPotenciador[4].SetActive(false);
            barraMejoraPotenciador[5].SetActive(false);
            Multiplicador.sprite = x5;
        }
        else if (GameController.current.NivelMultiplicador == 4)
        {
            barraMejoraPotenciador[0].SetActive(false);
            barraMejoraPotenciador[1].SetActive(false);
            barraMejoraPotenciador[2].SetActive(false);
            barraMejoraPotenciador[3].SetActive(false);
            barraMejoraPotenciador[4].SetActive(true);
            barraMejoraPotenciador[5].SetActive(false);
            Multiplicador.sprite = x6;
        }
        else if (GameController.current.NivelMultiplicador == 5)
        {
            barraMejoraPotenciador[0].SetActive(false);
            barraMejoraPotenciador[1].SetActive(false);
            barraMejoraPotenciador[2].SetActive(false);
            barraMejoraPotenciador[3].SetActive(false);
            barraMejoraPotenciador[4].SetActive(false);
            barraMejoraPotenciador[5].SetActive(true);
            Multiplicador.sprite = x6;
        }
    }

    public void MejoraVision()
    {
        if (GameController.current.NivelVision == 0)
        {
            barraMejoraVision[0].SetActive(true);
            barraMejoraVision[1].SetActive(false);
            barraMejoraVision[2].SetActive(false);
            barraMejoraVision[3].SetActive(false);
            barraMejoraVision[4].SetActive(false);
            barraMejoraVision[5].SetActive(false);
        }
        else if (GameController.current.NivelVision == 1)
        {
            barraMejoraVision[0].SetActive(false);
            barraMejoraVision[1].SetActive(true);
            barraMejoraVision[2].SetActive(false);
            barraMejoraVision[3].SetActive(false);
            barraMejoraVision[4].SetActive(false);
            barraMejoraVision[5].SetActive(false);
        }
        else if (GameController.current.NivelVision == 2)
        {
            barraMejoraVision[0].SetActive(false);
            barraMejoraVision[1].SetActive(false);
            barraMejoraVision[2].SetActive(true);
            barraMejoraVision[3].SetActive(false);
            barraMejoraVision[4].SetActive(false);
            barraMejoraVision[5].SetActive(false);
        }
        else if (GameController.current.NivelVision == 3)
        {
            barraMejoraVision[0].SetActive(false);
            barraMejoraVision[1].SetActive(false);
            barraMejoraVision[2].SetActive(false);
            barraMejoraVision[3].SetActive(true);
            barraMejoraVision[4].SetActive(false);
            barraMejoraVision[5].SetActive(false);
        }
        else if (GameController.current.NivelVision == 4)
        {
            barraMejoraVision[0].SetActive(false);
            barraMejoraVision[1].SetActive(false);
            barraMejoraVision[2].SetActive(false);
            barraMejoraVision[3].SetActive(false);
            barraMejoraVision[4].SetActive(true);
            barraMejoraVision[5].SetActive(false);
        }
        else if (GameController.current.NivelVision == 5)
        {
            barraMejoraVision[0].SetActive(false);
            barraMejoraVision[1].SetActive(false);
            barraMejoraVision[2].SetActive(false);
            barraMejoraVision[3].SetActive(false);
            barraMejoraVision[4].SetActive(false);
            barraMejoraVision[5].SetActive(true);
        }
    }
}
