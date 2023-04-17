using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;
    public int cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(cameraDesiredLookAt != null)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, cameraDesiredLookAt.rotation, cameraSpeed * Time.deltaTime);
        }
    }

    public void LookAtShop(Transform menuTransform)
    {
        cameraDesiredLookAt = menuTransform;
    }
}
