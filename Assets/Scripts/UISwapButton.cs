using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISwapButton : MonoBehaviour
{
    public Button runButton;
    public Button stopButton;

    public void SwapButtons()//��, ������������
    {
        runButton.gameObject.SetActive(!runButton.IsActive());
        stopButton.gameObject.SetActive(!stopButton.IsActive());
    }
}
