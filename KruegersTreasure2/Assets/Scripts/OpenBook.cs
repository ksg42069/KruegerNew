using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    private Animator animator;    
    bool isOpen = false;   
  
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }   
    public void ActivateTrigger()
    {
        if (!isOpen)
        {
            animator.Play("openBook");
            isOpen = true;
        }
        else
        {
            animator.Play("closeBook");
            isOpen = false;
        }
    }
}
