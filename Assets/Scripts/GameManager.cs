using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool isRunning = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        gameManager = this;
    }

    void Update()
    {

    }

    public void StartTheRun()
    {
        isRunning = true;
    }

    public void StopTheRun()
    {
        isRunning = false;
    }
}
