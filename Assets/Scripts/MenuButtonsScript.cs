using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsScript : MonoBehaviour
{
    public GameObject levels_panel;
    public GameObject credits_panel;
    public GameObject game_name;

    public void ButtonStart()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        levels_panel.SetActive(!levels_panel.activeSelf);
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
    public void ButtonJam()
    {
        Application.OpenURL("https://itch.io/jam/mospolyjam-2");
    }
    public void PanelCredits()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        credits_panel.SetActive(!credits_panel.activeSelf);
        game_name.SetActive(!game_name.activeSelf);
    }
}
