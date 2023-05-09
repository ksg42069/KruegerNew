using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabSwitchController : MonoBehaviour
{
    public float correctValue;
    public GameObject switchLight;
    public Material sGreen, sRed;
    float rotz;

    private void Start()
    {
        switchLight.GetComponent<Renderer>().material = sRed;
    }
    private void Update()
    {
        if (this.gameObject.transform.localEulerAngles.z>180)
        {
            rotz = this.gameObject.transform.localEulerAngles.z - 360;
        }
        else
        {
            rotz = this.gameObject.transform.localEulerAngles.z;
        }

        if (correctValue - 5f < rotz && rotz < correctValue + 5f)
        {
            switchLight.GetComponent<Renderer>().material = sGreen;
        }
        else
        {
            switchLight.GetComponent<Renderer>().material = sRed;            
        }
            
    }
}
