using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabPodController : MonoBehaviour
{
    public GameObject sw1, sw2, sw3;
    public Material mat;    
    string matName, checkMatName1, checkMatName2, checkMatName3;

    private void Start()
    {
        matName = mat.name;
    }
    private void Update()
    {

        checkMatName1 = sw1.GetComponent<Renderer>().sharedMaterial.name;
        checkMatName2 = sw2.GetComponent<Renderer>().sharedMaterial.name;
        checkMatName3 = sw3.GetComponent<Renderer>().sharedMaterial.name;

        if (matName == checkMatName1 && matName == checkMatName2 && matName == checkMatName3)
        {
            this.GetComponent<Animator>().Play("open");            
        }
    }    
}
