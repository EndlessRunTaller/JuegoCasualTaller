using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campodevision : MonoBehaviour
{
    float x = 5f;
    float y = 5f;
    float z = 5f;
    public Vector3 newSize = Vector3.one;
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            Debug.Log("adsdsa");
            x += Time.deltaTime;
            y += Time.deltaTime;
            newSize = new Vector3(x, y, z);
            transform.localScale = newSize;
        }
    }
}
