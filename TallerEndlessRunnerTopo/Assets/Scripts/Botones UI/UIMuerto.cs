using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMuerto : MonoBehaviour
{
    public PlayerController player;
    public GameObject activarUI;
    public int numeroEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.Vida)
        {
            activarUI.SetActive(true);
        }
    }

    public void BotonReiniciar()
    {
        if(GameController.current.Vida == 0 && GameController.current.NivelVIda == 0)
        {
            GameController.current.Vida = GameController.current.Vida + 1;
        }
        else if(GameController.current.Vida == 0 && GameController.current.NivelVIda == 1)
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
        SceneManager.LoadScene(numeroEscena);
        Time.timeScale = 1;
    }

}
