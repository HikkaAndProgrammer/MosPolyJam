using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 startPos;
    public static GameManager gameManager;
    public bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameManager =this;
        startPos = player.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTheRun()
    {
        isMoving = true;
    }

    public void StopTheRun()
    {
        isMoving=false;
        player.position = startPos;
        
    }
}
