using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public PlayerAnimation playerAnimation;
    private Vector2 direction;

    int carril = 1; //carriles, 0 abajo, 1 centro, 2 arriba
    float distancia = 3f; //Distancia entre carriles

    public float forwardSpeed; //Velocidad horizontal


    int speed = 20; //velocidad vertical (transicion entre carriles) para mas fluidez

    //Raycast
    public float RayDistance;
    private Transform RaycastChracterUp;
    private Transform RaycastChracterDown;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        RaycastChracterUp = transform.Find("RaycastUp");
        RaycastChracterDown = transform.Find("RaycastDown");
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = forwardSpeed;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            carril++;
            if(carril == 3)
            {
                carril = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            carril--;
            if (carril == -1)
            {
                carril = 0;
            }
        }


        Vector2 targePosition = transform.position.x * transform.right;

        if(carril == 0)
        {
            targePosition += Vector2.down * distancia;
        }
        else if(carril == 2){
            targePosition += Vector2.up * distancia;
        }
        controller.Move(direction * Time.fixedDeltaTime);
        transform.position = Vector2.Lerp(transform.position,targePosition,speed*Time.deltaTime);
        TocarObjetoArriba();
        TocarObjetoAbajo();
        AnimacionCorrer();

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
        playerAnimation.myAnimator.SetFloat("Correr", forwardSpeed);
    }
}
