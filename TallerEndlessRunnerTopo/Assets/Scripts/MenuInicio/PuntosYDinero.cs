using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosYDinero : MonoBehaviour
{
    public TextMeshProUGUI Dinero;
    public TextMeshProUGUI PuntosMaximos;

    public void Update()
    {
        Dinero.text = GameController.current.insectos.ToString();
    }
}
