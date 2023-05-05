using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMainGate : MonoBehaviour
{
    public Animation anim;
    public AudioSource sound;
    
    void Start()
    {
        //gate = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play();
            sound.Play();
            this.gameObject.SetActive(false);
        }
        
        
    }
}
