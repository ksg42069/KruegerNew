using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggers : MonoBehaviour
{
    public int ID;
    public GameObject switchcap;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LabPipe"))
        {
            if (other.TryGetComponent<PipeID>(out PipeID pipe))
            {
                if (pipe.pID == ID)
                {
                    switchcap.GetComponent<Animation>().Play("LabSwitchCapOpen");
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LabPipe"))
        {
            if (other.TryGetComponent<PipeID>(out PipeID pipe))
            {
                if (pipe.pID == ID)
                {
                    switchcap.GetComponent<Animation>().Play("LabSwitchCapClose");
                }
            }
        }
    }
}
