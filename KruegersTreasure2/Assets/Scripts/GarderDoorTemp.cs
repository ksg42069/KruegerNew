using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarderDoorTemp : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Emblem"))
        {
            door.GetComponent<Animator>().Play("open");            
        }
    }
}
