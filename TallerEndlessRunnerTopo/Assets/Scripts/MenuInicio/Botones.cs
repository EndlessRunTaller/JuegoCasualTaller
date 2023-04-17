using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public int numeroScena;

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    private void Start()
    {
        currentView = transform;
    }

    public void BotonJugar()
    {
        if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 0)
        {
            GameController.current.Vida = GameController.current.Vida + 1;
        }
        else if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 1)
        {
            GameController.current.Vida = GameController.current.Vida + 2;
        }
        else if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 2)
        {
            GameController.current.Vida = GameController.current.Vida + 3;
        }
        else if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 3)
        {
            GameController.current.Vida = GameController.current.Vida + 4;
        }
        else if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 4)
        {
            GameController.current.Vida = GameController.current.Vida + 5;
        }
        else if (GameController.current.Vida == 0 && GameController.current.NivelVIda == 5)
        {
            GameController.current.Vida = GameController.current.Vida + 6;
        }
        SceneManager.LoadScene(numeroScena);
        Time.timeScale = 1;
    }

    public void BotonTienda()
    {
        currentView = views[1];
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime*transitionSpeed);
    }
}
