using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messege : MonoBehaviour
{
    public bool isSus = false;
    public bool isAmogus = false;
    public Animator animator;

    public void Sus()
    {
        isSus = true;
        animator.SetBool("isSus", true);
    }

    public void Amogus()
    {
        isAmogus = true;
        animator.SetBool("isAmogus", true);
    }

    
}
