using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockManager : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            StartCoroutine(LoadLevel(0));
        }
    }

    public void GoTo1()
    {
        if (InteractibleA.lvlUnlock[0] == true)
        {
            InteractibleA.lvlIndex = 3;
            StartCoroutine(LoadLevel(3));
        }
    }
    public void GoTo2()
    {
        if (InteractibleA.lvlUnlock[1] == true)
        {
            InteractibleA.lvlIndex = 4;
            StartCoroutine(LoadLevel(4));
        }
    }
    public void GoTo3()
    {
        if (InteractibleA.lvlUnlock[2] == true)
        {
            InteractibleA.lvlIndex = 5;
            StartCoroutine(LoadLevel(5));
        }
    }
    public void GoTo4()
    {
        if (InteractibleA.lvlUnlock[3] == true)
        {
            InteractibleA.lvlIndex = 6;
            StartCoroutine(LoadLevel(6));
        }
    }
    public void GoTo5()
    {
        if (InteractibleA.lvlUnlock[4] == true)
        {
            InteractibleA.lvlIndex = 7;
            StartCoroutine(LoadLevel(7));
        }
    }
    public void GoTo6()
    {
        if (InteractibleA.lvlUnlock[5] == true)
        {
            InteractibleA.lvlIndex = 8;
            StartCoroutine(LoadLevel(8));
        }
    }
    public void GoTo7()
    {
        if (InteractibleA.lvlUnlock[6] == true)
        {
            InteractibleA.lvlIndex = 9;
            StartCoroutine(LoadLevel(9));
        }
    }
    public void GoTo8()
    {
        if (InteractibleA.lvlUnlock[7] == true)
        {
            InteractibleA.lvlIndex = 10;
            StartCoroutine(LoadLevel(10));
        }
    }
    public void GoTo9()
    {
        if (InteractibleA.lvlUnlock[8] == true)
        {
            InteractibleA.lvlIndex = 11;
            StartCoroutine(LoadLevel(11));
        }
    }
    public void GoTo10()
    {
        if (InteractibleA.lvlUnlock[9] == true)
        {
            InteractibleA.lvlIndex = 12;
            StartCoroutine(LoadLevel(12));
        }
    }
    public void GoTo11()
    {
        if (InteractibleA.lvlUnlock[10] == true)
        {
            InteractibleA.lvlIndex = 13;
            StartCoroutine(LoadLevel(13));
        }
    }
    public void GoTo12()
    {
        if (InteractibleA.lvlUnlock[11] == true)
        {
            InteractibleA.lvlIndex = 14;
            StartCoroutine(LoadLevel(14));
        }
    }
    public void GoTo13()
    {
        if (InteractibleA.lvlUnlock[12] == true)
        {
            InteractibleA.lvlIndex = 15;
            StartCoroutine(LoadLevel(15));
        }
    }
    public void GoTo14()
    {
        if (InteractibleA.lvlUnlock[13] == true)
        {
            InteractibleA.lvlIndex = 16;
            StartCoroutine(LoadLevel(16));
        }
    }
    public void GoTo15()
    {
        if (InteractibleA.lvlUnlock[14] == true)
        {
            InteractibleA.lvlIndex = 17;
            StartCoroutine(LoadLevel(17));
        }
    }
    public void GoTo16()
    {
        if (InteractibleA.lvlUnlock[15] == true)
        {
            int req = 0;
            for(int n = 0; n < Static.AMOGS.Length; n++)
            {
                if(Static.AMOGS[n] == true)
                {
                    req++;
                }
            }
            if(req == 15)
            {
                InteractibleA.lvlIndex = 18;
                StartCoroutine(LoadLevel(18));
            }
            
        }
    }



    IEnumerator LoadLevel(int levelIndex)
    {
        animator.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}