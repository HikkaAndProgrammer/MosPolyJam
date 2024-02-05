using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISwapButton : MonoBehaviour
{
    public static UISwapButton uiSwapButton;
    public Button runButton;
    public Button stopButton;

    void Update() //��, ������������  <------ Че за коммент на татарском???
    {
        if (GameManager.gameManager.isRunning)
        {
            stopButton.gameObject.SetActive(true);
            runButton.gameObject.SetActive(false);
        }
        else
        {
            runButton.gameObject.SetActive(true);
            stopButton.gameObject.SetActive(false);
        }
    }
}
