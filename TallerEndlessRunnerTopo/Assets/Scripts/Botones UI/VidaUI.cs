using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaUI : MonoBehaviour
{
    public GameObject[] Corazones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MostrarCorazones();

    }
    public void MostrarCorazones()
    {
        if (GameController.current.Vida == 0)
        {
            Corazones[0].SetActive(false);
            Corazones[1].SetActive(false);
            Corazones[2].SetActive(false);
            Corazones[3].SetActive(false);
            Corazones[4].SetActive(false);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 1)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(false);
            Corazones[2].SetActive(false);
            Corazones[3].SetActive(false);
            Corazones[4].SetActive(false);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 2)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(true);
            Corazones[2].SetActive(false);
            Corazones[3].SetActive(false);
            Corazones[4].SetActive(false);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 3)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(true);
            Corazones[2].SetActive(true);
            Corazones[3].SetActive(false);
            Corazones[4].SetActive(false);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 4)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(true);
            Corazones[2].SetActive(true);
            Corazones[3].SetActive(true);
            Corazones[4].SetActive(false);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 5)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(true);
            Corazones[2].SetActive(true);
            Corazones[3].SetActive(true);
            Corazones[4].SetActive(true);
            Corazones[5].SetActive(false);
        }
        else if (GameController.current.Vida == 6)
        {
            Corazones[0].SetActive(true);
            Corazones[1].SetActive(true);
            Corazones[2].SetActive(true);
            Corazones[3].SetActive(true);
            Corazones[4].SetActive(true);
            Corazones[5].SetActive(true);
        }
    }
}
