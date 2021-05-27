using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public Animator animator;
    public float transitionTime = 1f;



    public void LoadNextLevel()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        InteractibleA.lvlIndex = data.lvlId;

        for (int n = 0; n < 15; n++)
        {
            Static.AMOGS[n] = data.amogs[n];
        }

        for (int n = 0; n < 16; n++)
        {
            InteractibleA.lvlUnlock[n] = data.lvlUn[n];
        }

        StartCoroutine(LoadLevel(InteractibleA.lvlIndex));
    }

    public void Levels()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        InteractibleA.lvlIndex = data.lvlId;

        for (int n = 0; n < 15; n++)
        {
            Static.AMOGS[n] = data.amogs[n];
        }

        for (int n = 0; n < 16; n++)
        {
            InteractibleA.lvlUnlock[n] = data.lvlUn[n];
        }

        StartCoroutine(LoadLevel(1));
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    IEnumerator LoadLevel(int levelIndex)
    {

        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
