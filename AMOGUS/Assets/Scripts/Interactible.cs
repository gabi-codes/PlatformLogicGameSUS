using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactible : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public Animator animator;
    public bool isSus = false;
    public bool isAmogus = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSus)
        {
            animator.SetBool("isSus", true);
        }
        else
        {
            animator.SetBool("isSus", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            isSus = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isSus = false;

        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            isSus = false;

        }
    }
}
