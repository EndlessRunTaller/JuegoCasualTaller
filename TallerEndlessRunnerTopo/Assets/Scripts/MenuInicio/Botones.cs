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
        SceneManager.LoadScene(numeroScena);
    }

    public void BotonTienda()
    {
        currentView = views[1];
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime*transitionSpeed);
    }
}
