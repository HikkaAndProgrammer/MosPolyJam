using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float stepDuration = 1f;
    [SerializeField] private float tileSize = 1f;
    [SerializeField] private string[] path;
    //[SerializeField] private AnimationCurve curve;
    private Vector3 directionMove;
    public int currentDirIndex = 0;
    private Vector3 startPos;
    /// <summary>
    ///private bool playerIsMoving = false;
    /// </summary>
    void Update()
    {

        if(GameManager.gameManager.isMoving){
            Move();
        }
        else
        {
           currentDirIndex = 0;
        }
    }
    void Start(){
        startPos = transform.position;
    }
    void Move(){
        switch (path[currentDirIndex]){
                case "up":
                    directionMove = Vector3.up;
                    break;
                case "down":
                    directionMove = Vector3.down;
                    break;
                case "left":
                    directionMove = Vector3.left;
                    break;
                case "right":
                    directionMove = Vector3.right;
                    break;
            }
        transform.position += directionMove * Time.deltaTime / stepDuration;
        if (Vector3.Distance(startPos, transform.position) >= 1){
            if(currentDirIndex < path.Length){
                currentDirIndex++;
                transform.position = startPos + directionMove;
                startPos = transform.position;
            }
            else{
                GameManager.gameManager.isMoving = false;
            }
        }
    }

}
