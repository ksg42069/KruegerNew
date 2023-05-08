using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitchCollider : MonoBehaviour
{
    public GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        obj.SetActive(true);
    }
}
