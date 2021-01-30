using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingLight : MonoBehaviour
{
    public float rotationSpeed = 0.025f;


    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.forward * rotationSpeed;
    }
}
