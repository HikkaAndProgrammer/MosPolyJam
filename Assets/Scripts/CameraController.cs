using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensitivity = 0.001f;

    private Vector3 origin;
    private Vector3 difference;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            origin = Input.mousePosition;
            return;
        }

        if (Input.GetMouseButton(0))
        {
            transform.position -= (Input.mousePosition - origin) * sensitivity;
            origin = Input.mousePosition;
        }
    }
}
