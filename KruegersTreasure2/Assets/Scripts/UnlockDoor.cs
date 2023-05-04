using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class UnlockDoor : MonoBehaviour
{
    public GameObject key;
    public Animation anim;

    private void Start()
    {
        
    }
    public void GrabKey()
    {
        StartCoroutine(LevelEnd());                
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(1.0f);

        anim.Play("openDoor");   

        yield return new WaitForSeconds(0.5f);
        
        key.SetActive(false);
    }
}
