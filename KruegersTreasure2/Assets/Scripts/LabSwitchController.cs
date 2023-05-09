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
        rotz = this.gameObject.transform.rotation.eulerAngles.z;
        
        switchLight.GetComponent<Renderer>().material = sRed;
    }
    private void Update()
    {
        Debug.Log(rotz);

        if (correctValue - 7.5f < rotz && rotz < correctValue + 7.5f)
            switchLight.GetComponent<Renderer>().material = sGreen;
        else
            switchLight.GetComponent<Renderer>().material = sRed;
    }
}
