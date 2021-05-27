using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator animator;

    //public void Start()
    //{
      //  SaveSystem.SaveProgress();
    //}

    public void Update()
    {
        Debug.Log(Static.AMOGS[4]);
    }

    public void ChangeLevel()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(InteractibleA.lvlIndex));
    }

    public void Levels()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void BackToMenu()
    {
        SaveSystem.SaveProgress();
        StartCoroutine(LoadLevel(0));
    }

    public void TransitionLvl()
    {
        SaveSystem.SaveProgress();
        StartCoroutine(LoadLevel(2));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
