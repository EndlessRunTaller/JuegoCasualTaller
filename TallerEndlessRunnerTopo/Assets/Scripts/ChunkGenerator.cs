using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public GameObject theChunks;
    public Transform generationPoint;
    public float distanceBetween;

    private float ChunkWidthX;
    void Start()
    {
        ChunkWidthX = theChunks.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + ChunkWidthX + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(theChunks, transform.position, transform.rotation);

        }
    }
}
