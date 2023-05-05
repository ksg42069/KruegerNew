using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLevelSwitch : MonoBehaviour
{
    public Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("openDoor");
            this.gameObject.SetActive(false);
        }
        
    }   
    
}
