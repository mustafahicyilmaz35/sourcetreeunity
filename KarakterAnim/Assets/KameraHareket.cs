using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    [Range(50,300)]
    public float sens;
    public Transform body;
    float xRot = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= rotY;

        xRot = Mathf.Clamp(xRot, -80f, 80f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        body.Rotate(Vector3.up * rotX);
    }
}
