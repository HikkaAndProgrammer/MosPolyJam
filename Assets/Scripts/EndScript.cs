using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);

        if (hit && hit.transform.tag == "Player")
        {
            GameManager.gameManager.isWinned = true;
        }
    }
}
