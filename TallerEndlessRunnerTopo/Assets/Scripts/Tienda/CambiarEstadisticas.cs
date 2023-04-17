using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEstadisticas : MonoBehaviour
{
    public int NivelMultiplicador = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NivelMultiplicador == 0)
        {
            GameController.current.pointsPerSecond = 5;
        }
        else if(NivelMultiplicador == 1)
        {
            GameController.current.pointsPerSecond = 1000;
        }
    }

    public void BotonMultiplicador()
    {
        if(GameController.current.insectos > 50)
        {
            NivelMultiplicador = NivelMultiplicador + 1;
            GameController.current.insectos = GameController.current.insectos - 50;
        }
    }
}
