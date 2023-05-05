using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLevelEnter : MonoBehaviour
{
    public Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.Play("closeDoor");
            this.gameObject.SetActive(false);
        }

    }
}
