using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkDestroyer : MonoBehaviour
{
    public GameObject ChunkDestruictionPoint;

    void Start()
    {
        ChunkDestruictionPoint = GameObject.Find("ChunkDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < ChunkDestruictionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
