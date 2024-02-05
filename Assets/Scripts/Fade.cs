using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    private Fade instance = null;
    [SerializeField] Animator fadeAnimator;
    [SerializeField] private int SceneCount;

    private int levelToLoadIndex;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (GameManager.gameManager.isWinned)
        {
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex + 1;
        if (index <= SceneCount)
        {
            FadeToLevel(index);
        }
        else
        {
            FadeToLevel(0);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoadIndex = levelIndex;
        fadeAnimator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoadIndex);
    }
}
