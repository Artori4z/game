using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]private Vector3 vector;
    [SerializeField]private float RotationSpeed;
    [SerializeField] private float xMin;
    [SerializeField] private float xMax;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;
    private float yRotation;
    private float xRotation;
    private void Update()
    {
        float UpDown = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        float LeftRight = Input.GetKey(KeyCode.A) ? 1 : Input.GetKey(KeyCode.D) ? -1 : 0;
        xRotation -= UpDown * RotationSpeed * Time.deltaTime;
        yRotation -= LeftRight * RotationSpeed * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation,yMin,yMax);
        yRotation = Mathf.Clamp(yRotation,xMin,xMax);
        transform.localRotation = Quaternion.Euler(xRotation,yRotation,0f);
    }

}
