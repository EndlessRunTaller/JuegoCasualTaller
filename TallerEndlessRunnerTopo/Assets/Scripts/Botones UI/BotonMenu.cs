using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    public int NumeroEscena;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene(NumeroEscena);
    }
}
