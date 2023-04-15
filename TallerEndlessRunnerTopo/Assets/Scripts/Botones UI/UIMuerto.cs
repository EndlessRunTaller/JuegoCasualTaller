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
        SceneManager.LoadScene(numeroEscena);
        Time.timeScale = 1;
    }

}
