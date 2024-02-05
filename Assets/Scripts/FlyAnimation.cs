using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAnimation : MonoBehaviour
{
    [SerializeField] private float amplitude = 0.2f;
    [SerializeField] private float timeDuration = 4f;

    private float elapsedTime = 0;
    private float startHeight;

    void Start()
    {
        startHeight = transform.position.y;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        transform.position = new Vector2(transform.position.x, startHeight + Mathf.Sin(elapsedTime * 2 * Mathf.PI / timeDuration) * amplitude);
    }
}
