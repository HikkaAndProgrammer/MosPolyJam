using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float timeToMove = 3f;
    public string[] directions = {"up", "right", "down"}; //Список ходов

    private IEnumerator Wait(float time) {
        yield return new WaitForSeconds(3);
    }

    void Start() {
        Movement();
    }

    public void Movement() {
        foreach (string move in directions){
            StartCoroutine(Wait(timeToMove));

            switch (move) {
                case "up": transform.position += Vector3.up; break;
                case "down": transform.position += Vector3.down; break;
                case "right": transform.position += Vector3.right; break;
                case "left": transform.position += Vector3.left; break;
            }
        }
    }
}
