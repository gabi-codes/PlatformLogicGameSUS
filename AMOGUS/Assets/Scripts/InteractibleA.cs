using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class InteractibleA : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent unityEvent;
    public KeyCode interactKey;
    public Animator animator;
    public bool isSus = false;
    public bool isAmogus = false;
    public int unlockIndex = 0;
    public int players = 0;
    public static int lvlIndex = 3;
    public static bool[] lvlUnlock = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

    LevelLoader levelLoader;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (players == 2)
        {
            animator.SetBool("isAmogus", true);
            if (Input.GetKeyDown(interactKey))
            {   
                unlockIndex = SceneManager.GetActiveScene().buildIndex;
                unlockIndex -= 2;

                lvlUnlock[unlockIndex] = true;
                lvlIndex++;

                unityEvent.Invoke();
                
                  
            }
        }
        else
        {
            animator.SetBool("isAmogus", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            players++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            players--;

        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            players--;

        }
    }
}