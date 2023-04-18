using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerAnimation playerAnimation;
    public ScoreManager scoreManager;

    private Vector2 targetPos;
    private float distanciaY = 3f; //Distancia entre carriles

    private int speed = 50; //velocidad vertical (transicion entre carriles) para mas fluidez

    public GameObject Player;
    public bool Vida = true;

    //Raycast
    public float RayDistance;
    private Transform RaycastChracterUp;
    private Transform RaycastChracterDown;

    void Start()
    {
        RaycastChracterUp = transform.Find("RaycastUp");
        RaycastChracterDown = transform.Find("RaycastDown");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        
        if(scoreManager.scoreCount < 200)
        {
            float MaxAltura = 3f;
            float minAltura = -3f;

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y + distanciaY);
                playerAnimation.myAnimator.SetTrigger("Arriba");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - distanciaY);
                playerAnimation.myAnimator.SetTrigger("Abajo");
            }
        }
        if (scoreManager.scoreCount > 200 && scoreManager.scoreCount < 500)
        {
            float MaxAltura = 0f;
            float minAltura = -6f;

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y + distanciaY);
                playerAnimation.myAnimator.SetTrigger("Arriba");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - distanciaY);
                playerAnimation.myAnimator.SetTrigger("Abajo");
            }
            if(transform.position.y == 3)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - distanciaY);
            }
        }
        if (scoreManager.scoreCount > 500)
        {
            float MaxAltura = -3f;
            float minAltura = -9f;

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < MaxAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y + distanciaY);
                playerAnimation.myAnimator.SetTrigger("Arriba");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minAltura)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - distanciaY);
                playerAnimation.myAnimator.SetTrigger("Abajo");
            }
            if (transform.position.y == 0)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - distanciaY);
            }
        }

        AnimacionCorrer();
        Morir();

        

    }

    void TocarObjetoArriba()
    {
        Debug.DrawRay(RaycastChracterUp.position, RaycastChracterUp.up * RayDistance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(RaycastChracterUp.position, RaycastChracterUp.up, out hit, RayDistance, LayerMask.GetMask("Suelo")) && Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerAnimation.myAnimator.SetTrigger("CambiarCarril");
        }
    }
    void TocarObjetoAbajo()
    {
        Debug.DrawRay(RaycastChracterDown.position, RaycastChracterDown.up * RayDistance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(RaycastChracterDown.position, RaycastChracterDown.up, out hit, RayDistance, LayerMask.GetMask("Suelo")) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerAnimation.myAnimator.SetTrigger("CambiarCarril");
        }
    }
    void AnimacionCorrer()
    {
        playerAnimation.myAnimator.SetFloat("Correr", 1.6f);
    }

    public void Morir()
    {
        if (GameController.current.Vida == 0)
        {
            Player.SetActive(false);
            Vida = false;
            Time.timeScale = 0;
        }
    }
}
