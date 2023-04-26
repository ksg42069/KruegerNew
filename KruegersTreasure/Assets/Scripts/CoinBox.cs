using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    public Animator anim;
    bool isClose = true;
    
    // Start is called before the first frame update
    public void openBox()
    {
        if (isClose)
        {
            anim.Play("open");
            isClose = false;
        }
        else
        {
            anim.Play("close");
            isClose = true;
        }
    }
}
