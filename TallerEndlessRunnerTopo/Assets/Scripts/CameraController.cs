using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController theplayer;
    private Vector3 lastPlayerPosition;
    private float distanceToMove;

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
    }
}
