using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float stepDuration = 1f; // time for one move
    [SerializeField] private float tileSize = 1f;     // length of one move (== length of one tile)
    [SerializeField] private Vector2 startDirection;  // Start Direction (0 == down, 1 == left, 2 == up, 3 == right)
    [SerializeField] private Animator animator;       // Animator component

    private Vector3 originPosition;                   // global start pos
    private Vector3 startPosition;                    // on every move start pos
    private Vector3 endPosition;                      // on every move end pos
    private Vector3 direction = Vector2.right;        // move direction
    private float elapsedTime;                        // time elapsed since the start of movement
    private bool isMoving = false;                    // true if moving (!= gameManager.isRunning) (isRunning means all run, but isMoving means one move)
    private bool isAlive = true;

    void Start()
    {
        originPosition = transform.position;
    }

    void Update()
    {
        if (GameManager.gameManager.isRunning)
        {
            Move();
        }
        else
        {
            transform.position = originPosition;
            direction = startDirection;
            isMoving = false;
            isAlive = true;
        }

        animator.SetBool("IsRunning", GameManager.gameManager.isRunning && isAlive);

        if      (direction == Vector3.down)  animator.SetInteger("Direction", 0); // ТУТ CASE НЕ РАБОТАЛ, ПРАВДА))) НЕ БЕЙТЕ)
        else if (direction == Vector3.left)  animator.SetInteger("Direction", 1); // CASE DON'T WORK HERE, DON'T KILL ME PLS))
        else if (direction == Vector3.up)    animator.SetInteger("Direction", 2);
        else if (direction == Vector3.right) animator.SetInteger("Direction", 3);
    }

    void Move()
    {
        if (isMoving)
        {
            elapsedTime += Time.deltaTime;

            transform.position = Vector2.Lerp(startPosition, endPosition, elapsedTime / stepDuration);

            if (elapsedTime >= stepDuration)
            {
                transform.position = new Vector2(Mathf.Round(endPosition.x - 0.5f) + 0.5f, Mathf.Round(endPosition.y - 0.5f) + 0.5f);
                isMoving = false;
            }
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);

            if (hit)
            {
                if (hit.transform.tag == "RotateLeft")
                {
                    direction = Quaternion.AngleAxis(90, Vector3.forward) * direction;
                }
                else if (hit.transform.tag == "RotateRight")
                {
                    direction = Quaternion.AngleAxis(-90, Vector3.forward) * direction;
                }

                isMoving = true;
                elapsedTime = 0;

                startPosition = transform.position;
                endPosition = transform.position + direction * tileSize;
            }
            else
            {
                isAlive = false;
            }
        }
    }

}
