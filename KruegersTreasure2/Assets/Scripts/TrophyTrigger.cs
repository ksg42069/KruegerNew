using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyTrigger : MonoBehaviour
{
    public int ID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trophy"))
        {
            if (other.TryGetComponent<TrophyID>(out TrophyID trophy))
            {
                if (trophy.tID == ID)
                {
                    TrophyController.instance.AddTrophy(ID);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trophy"))
        {
            if (other.TryGetComponent<TrophyID>(out TrophyID trophy))
            {
                if (trophy.tID == ID)
                {
                    TrophyController.instance.RemoveTrophy(ID);
                }
            }
        }
    }
}
