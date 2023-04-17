using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campodevision : MonoBehaviour
{
    public Vector3 newSize = Vector3.one;
    void Update()
    {
        transform.localScale = new Vector3(GameController.current.Ejex, GameController.current.Ejey, transform.localScale.z);
    }
}
