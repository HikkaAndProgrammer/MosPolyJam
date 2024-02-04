using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPlatform : MonoBehaviour
{
    private Vector3 origin;
    private Vector3 difference;
    [SerializeField] private Transform abc;

    private bool isDragging = false;

    private Vector3 mouseWorldPos()
    {
        Vector3 result = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        result.z = 0.0f;

        return result;
    }

    private void ceilPosition()
    {
        Vector3 result = new Vector3(0, 0, 0);

        result.x = Mathf.Round(transform.position.x);
        result.y = Mathf.Round(transform.position.y);

        transform.position = result;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos(), Vector2.zero);

            if (hit != null && hit.transform == transform && !isDragging)
            {
                origin = transform.position;
                difference = mouseWorldPos() - transform.position;
                isDragging = true;
            }
        }

        if (isDragging && !Input.GetMouseButton(0))
        {
            ceilPosition();
            isDragging = false;
        }

        if (isDragging && Input.GetMouseButton(0))
        {
            transform.position = mouseWorldPos() - difference;
        }
    }
}
