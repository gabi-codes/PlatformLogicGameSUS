using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLvl : MonoBehaviour
{
    private Scene scene;
    public Animator animator;
    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
        }


        if (Input.GetKeyDown("escape"))
        {
            SaveSystem.SaveProgress();
            StartCoroutine(LoadLevel(0));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
