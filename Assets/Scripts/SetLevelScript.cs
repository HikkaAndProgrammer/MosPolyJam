using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SetLevelScript : MonoBehaviour
{
    public void StartScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
