using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float power = 2;

    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(power * Camera.main.ScreenToWorldPoint(Input.mousePosition).x, power * Camera.main.ScreenToWorldPoint(Input.mousePosition).y, startPos.z);
    }
}
