using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float timeToMove = 1;
    public string[] directions = {"up", "right", "down"};//Список ходов
    // Start is called before the first frame update
    void Start()
    {
        StartMovement();
    }
    public IEnumerator waitToMove(){
        yield return new WaitForSeconds(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMovement(){
        foreach (string move in directions){
            if(move == "up"){
                transform.position = transform.position + Vector3.up;
            }
            else if(move == "down"){
                transform.position = transform.position + Vector3.down;
            }
            else if(move == "right"){
                transform.position = transform.position + Vector3.right;
            }
            else if(move == "left"){
                transform.position = transform.position + Vector3.left;
            }
            Debug.Log(transform.position.ToString());
            StartCoroutine(waitToMove());
        }
    }
}
