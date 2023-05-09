using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLab : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Emblem"))
        {
            door.GetComponent<Animation>().Play("openDoor");
            this.gameObject.SetActive(false);
        }
    }
}
