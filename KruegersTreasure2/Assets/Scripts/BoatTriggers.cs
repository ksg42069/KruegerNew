using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTriggers : MonoBehaviour
{
    public int ID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            if (other.TryGetComponent<BoatID>(out BoatID boat))
            {
                if (boat.bID == ID)
                {
                    BoatController.instance.AddWing(ID);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boat"))
        {
            if (other.TryGetComponent<BoatID>(out BoatID boat))
            {
                if (boat.bID == ID)
                {
                    BoatController.instance.RemoveWing(ID);
                }
            }
        }
    }
}
