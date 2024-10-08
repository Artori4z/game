using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangCamera : MonoBehaviour
{
    [SerializeField] Vector3 NewPosition;
    [SerializeField] Camera Camera;
    [SerializeField] private float MoveSpeed;
    private void OnMouseDown()
    {
        ChangCam();
    }
    void ChangCam()
    {
        NewPosition -= NewPosition * MoveSpeed * Time.deltaTime;
        Camera.transform.position = NewPosition * MoveSpeed * Time.deltaTime;
       

    }
}
