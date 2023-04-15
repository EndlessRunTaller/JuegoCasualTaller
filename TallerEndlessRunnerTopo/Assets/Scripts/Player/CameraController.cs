using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController theplayer;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;
    public ScoreManager scoreManager;

    public Transform punto1;


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


        if (scoreManager.scoreCount > 100)
        {
            Camera.main.orthographicSize = 6;
            transform.position = Vector3.Lerp(transform.position, punto1.position, Time.deltaTime * 5);
           
        }

    }


}
