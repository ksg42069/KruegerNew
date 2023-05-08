using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class UnlockDoor : MonoBehaviour
{
    public Animation anim, key;
    public GameObject trigger;

    private void Start()
    {
        
    }
    
    public void GrabKey()
    {
        StartCoroutine(LevelEnd());                
    }

    IEnumerator LevelEnd()
    {
        key.Play();
        trigger.SetActive(true);
        
        yield return new WaitForSeconds(1.0f);

        anim.Play("openDoor");     
    }
}
