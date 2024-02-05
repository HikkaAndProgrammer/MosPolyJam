using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool isRunning = false;
    public bool isWinned = false;

    void Start()
    {
        gameManager = this;
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
