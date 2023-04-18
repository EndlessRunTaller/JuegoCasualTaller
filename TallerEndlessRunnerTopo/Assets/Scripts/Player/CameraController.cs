using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController theplayer;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    public ScoreManager scoreManager;

    public Transform[] puntos;


    void Start()
    {
        theplayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = theplayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = theplayer.transform.position.x - lastPlayerPosition.x;
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = theplayer.transform.position;


        if (scoreManager.scoreCount > 200 && scoreManager.scoreCount < 500)
        {
            Camera.main.orthographicSize = 6;
            transform.position = Vector3.Lerp(transform.position, puntos[0].position, Time.deltaTime * 5);
           
        }
        else if(scoreManager.scoreCount > 500)
        {
            Camera.main.orthographicSize = 6;
            transform.position = Vector3.Lerp(transform.position, puntos[1].position, Time.deltaTime * 5);
        }

    }


}
